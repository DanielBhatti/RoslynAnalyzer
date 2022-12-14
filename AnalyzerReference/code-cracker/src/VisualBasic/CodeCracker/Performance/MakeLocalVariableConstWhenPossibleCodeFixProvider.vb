Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.CodeActions
Imports Microsoft.CodeAnalysis.CodeFixes
Imports Microsoft.CodeAnalysis.Formatting
Imports Microsoft.CodeAnalysis.VisualBasic
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax
Imports System.Collections.Immutable
Imports System.Threading

Namespace Performance
    <ExportCodeFixProvider(LanguageNames.VisualBasic, Name:=NameOf(MakeLocalVariableConstWhenPossibleCodeFixProvider)), Composition.Shared>
    Public Class MakeLocalVariableConstWhenPossibleCodeFixProvider
        Inherits CodeFixProvider

        Public Overrides NotOverridable ReadOnly Property FixableDiagnosticIds As ImmutableArray(Of String) = ImmutableArray.Create(MakeLocalVariableConstWhenPossibleAnalyzer.Id)

        Public Overrides Function GetFixAllProvider() As FixAllProvider
            Return WellKnownFixAllProviders.BatchFixer
        End Function

        Public Overrides Function RegisterCodeFixesAsync(context As CodeFixContext) As Task
            Dim diagnostic = context.Diagnostics.First()
            Const message = "Make constant"
            context.RegisterCodeFix(CodeAction.Create(message, Function(c) MakeConstantAsync(context.Document, diagnostic, c), NameOf(MakeLocalVariableConstWhenPossibleCodeFixProvider)), diagnostic)
            Return Task.FromResult(0)
        End Function

        Public Async Function MakeConstantAsync(document As Document, diagnostic As Diagnostic, cancellationToken As CancellationToken) As Task(Of Document)
            Dim root = Await document.GetSyntaxRootAsync(cancellationToken).ConfigureAwait(False)
            Dim diagnosticSpan = diagnostic.Location.SourceSpan
            Dim localDeclaration = root.FindToken(diagnosticSpan.Start).Parent.AncestorsAndSelf().OfType(Of LocalDeclarationStatementSyntax).First()

            Dim declaration = localDeclaration.Declarators.First

            Dim dimModifier = localDeclaration.Modifiers.First()

            Dim constant = SyntaxFactory.Token(SyntaxKind.ConstKeyword).
            WithLeadingTrivia(dimModifier.LeadingTrivia).
            WithTrailingTrivia(dimModifier.TrailingTrivia).
            WithAdditionalAnnotations(Formatter.Annotation)

            Dim modifiers = localDeclaration.Modifiers.Replace(dimModifier, constant)

            Dim newLocalDeclaration = localDeclaration.
            WithModifiers(modifiers).
            WithLeadingTrivia(localDeclaration.GetLeadingTrivia()).
            WithTrailingTrivia(localDeclaration.GetTrailingTrivia()).
            WithAdditionalAnnotations(Formatter.Annotation)

            Dim newRoot = root.ReplaceNode(localDeclaration, newLocalDeclaration)
            Return document.WithSyntaxRoot(newRoot)
        End Function
    End Class
End Namespace