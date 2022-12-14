# C# 7.2 APIs supported via light-up

See [dotnet/roslyn@30a68f1](https://github.com/dotnet/roslyn/commit/30a68f16a0cb3d154a0fca41df38ec509dfe703c).

## Semantics

* [ ] `abstract Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.RegisterOperationAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind> operationKinds) -> void`
* [ ] `abstract Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.RegisterOperationBlockEndAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext> action) -> void`
* [ ] `abstract Microsoft.CodeAnalysis.SemanticModel.GetOperationCore(Microsoft.CodeAnalysis.SyntaxNode node, System.Threading.CancellationToken cancellationToken) -> Microsoft.CodeAnalysis.IOperation`
* [ ] `abstract Microsoft.CodeAnalysis.SemanticModel.RootCore.get -> Microsoft.CodeAnalysis.SyntaxNode`
* [ ] `Microsoft.CodeAnalysis.CommandLineArguments.DisplayLangVersions.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.AnalysisContext.RegisterOperationAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, params Microsoft.CodeAnalysis.OperationKind[] operationKinds) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext.RegisterOperationAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, params Microsoft.CodeAnalysis.OperationKind[] operationKinds) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext.CancellationToken.get -> System.Threading.CancellationToken`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext.Compilation.get -> Microsoft.CodeAnalysis.Compilation`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext.ContainingSymbol.get -> Microsoft.CodeAnalysis.ISymbol`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext.OperationAnalysisContext(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.ISymbol containingSymbol, Microsoft.CodeAnalysis.Compilation compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions options, System.Action<Microsoft.CodeAnalysis.Diagnostic> reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic, System.Threading.CancellationToken cancellationToken) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext.Options.get -> Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext.ReportDiagnostic(Microsoft.CodeAnalysis.Diagnostic diagnostic) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext.CancellationToken.get -> System.Threading.CancellationToken`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext.Compilation.get -> Microsoft.CodeAnalysis.Compilation`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext.OperationBlockAnalysisContext(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation> operationBlocks, Microsoft.CodeAnalysis.ISymbol owningSymbol, Microsoft.CodeAnalysis.Compilation compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions options, System.Action<Microsoft.CodeAnalysis.Diagnostic> reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic, System.Threading.CancellationToken cancellationToken) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext.OperationBlocks.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext.Options.get -> Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext.OwningSymbol.get -> Microsoft.CodeAnalysis.ISymbol`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext.ReportDiagnostic(Microsoft.CodeAnalysis.Diagnostic diagnostic) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.CancellationToken.get -> System.Threading.CancellationToken`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.Compilation.get -> Microsoft.CodeAnalysis.Compilation`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.OperationBlockStartAnalysisContext(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation> operationBlocks, Microsoft.CodeAnalysis.ISymbol owningSymbol, Microsoft.CodeAnalysis.Compilation compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions options, System.Threading.CancellationToken cancellationToken) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.OperationBlocks.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.Options.get -> Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.OwningSymbol.get -> Microsoft.CodeAnalysis.ISymbol`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext.RegisterOperationAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, params Microsoft.CodeAnalysis.OperationKind[] operationKinds) -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationActionsCount.get -> int`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationActionsCount.set -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationBlockActionsCount.get -> int`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationBlockActionsCount.set -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationBlockEndActionsCount.get -> int`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationBlockEndActionsCount.set -> void`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationBlockStartActionsCount.get -> int`
* [ ] `Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo.OperationBlockStartActionsCount.set -> void`
* [ ] `Microsoft.CodeAnalysis.ILocalSymbol.RefKind.get -> Microsoft.CodeAnalysis.RefKind`
* [ ] `Microsoft.CodeAnalysis.IMethodSymbol.RefKind.get -> Microsoft.CodeAnalysis.RefKind`
* [ ] `Microsoft.CodeAnalysis.IMethodSymbol.ReturnsByRefReadonly.get -> bool`
* [ ] `Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.IOperation.Accept(Microsoft.CodeAnalysis.Operations.OperationVisitor visitor) -> void`
* [ ] `Microsoft.CodeAnalysis.IOperation.Accept<TArgument, TResult>(Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult> visitor, TArgument argument) -> TResult`
* [ ] `Microsoft.CodeAnalysis.IOperation.Children.get -> System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.IOperation.ConstantValue.get -> Microsoft.CodeAnalysis.Optional<object>`
* [ ] `Microsoft.CodeAnalysis.IOperation.IsImplicit.get -> bool`
* [ ] `Microsoft.CodeAnalysis.IOperation.Kind.get -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.IOperation.Language.get -> string`
* [ ] `Microsoft.CodeAnalysis.IOperation.Parent.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.IOperation.Syntax.get -> Microsoft.CodeAnalysis.SyntaxNode`
* [ ] `Microsoft.CodeAnalysis.IOperation.Type.get -> Microsoft.CodeAnalysis.ITypeSymbol`
* [ ] `Microsoft.CodeAnalysis.IPropertySymbol.RefKind.get -> Microsoft.CodeAnalysis.RefKind`
* [ ] `Microsoft.CodeAnalysis.IPropertySymbol.ReturnsByRefReadonly.get -> bool`
* [ ] `Microsoft.CodeAnalysis.ModuleMetadata.IsDisposed.get -> bool`
* [ ] `Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.AddressOf = 64 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.AnonymousFunction = 35 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.AnonymousObjectCreation = 49 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Argument = 79 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ArrayCreation = 38 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ArrayElementReference = 23 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ArrayInitializer = 76 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Await = 41 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.BinaryOperator = 32 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Block = 2 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Branch = 7 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.CaseClause = 82 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.CatchClause = 80 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Coalesce = 34 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.CollectionElementInitializer = 52 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.CompoundAssignment = 43 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Conditional = 33 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ConditionalAccess = 46 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ConditionalAccessInstance = 47 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ConstantPattern = 85 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Conversion = 21 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DeclarationExpression = 70 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DeclarationPattern = 86 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DeconstructionAssignment = 69 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Decrement = 68 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DefaultValue = 61 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DelegateCreation = 60 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DynamicIndexerAccess = 58 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DynamicInvocation = 57 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DynamicMemberReference = 56 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.DynamicObjectCreation = 55 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Empty = 8 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.End = 18 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.EventAssignment = 45 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.EventReference = 30 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ExpressionStatement = 15 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.FieldInitializer = 72 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.FieldReference = 26 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Increment = 66 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.InstanceReference = 39 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.InterpolatedString = 48 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.InterpolatedStringText = 83 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Interpolation = 84 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Invalid = 1 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Invocation = 22 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.IsPattern = 65 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.IsType = 40 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Labeled = 6 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Literal = 20 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.LocalFunction = 16 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.LocalReference = 24 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Lock = 11 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Loop = 5 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.MemberInitializer = 51 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.MethodReference = 27 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.NameOf = 53 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.None = 0 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ObjectCreation = 36 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ObjectOrCollectionInitializer = 50 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.OmittedArgument = 71 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ParameterInitializer = 75 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.ParameterReference = 25 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Parenthesized = 44 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.PropertyInitializer = 74 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.PropertyReference = 28 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.RaiseEvent = 19 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Return = 9 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.SimpleAssignment = 42 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.SizeOf = 63 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Stop = 17 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Switch = 4 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.SwitchCase = 81 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Throw = 67 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.TranslatedQuery = 59 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Try = 12 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Tuple = 54 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.TypeOf = 62 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.TypeParameterObjectCreation = 37 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.UnaryOperator = 31 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.Using = 13 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.VariableDeclaration = 78 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.VariableDeclarationGroup = 3 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.VariableDeclarator = 77 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.VariableInitializer = 73 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.YieldBreak = 10 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.OperationKind.YieldReturn = 14 -> Microsoft.CodeAnalysis.OperationKind`
* [ ] `Microsoft.CodeAnalysis.Operations.ArgumentKind`
* [ ] `Microsoft.CodeAnalysis.Operations.ArgumentKind.DefaultValue = 3 -> Microsoft.CodeAnalysis.Operations.ArgumentKind`
* [ ] `Microsoft.CodeAnalysis.Operations.ArgumentKind.Explicit = 1 -> Microsoft.CodeAnalysis.Operations.ArgumentKind`
* [ ] `Microsoft.CodeAnalysis.Operations.ArgumentKind.None = 0 -> Microsoft.CodeAnalysis.Operations.ArgumentKind`
* [ ] `Microsoft.CodeAnalysis.Operations.ArgumentKind.ParamArray = 2 -> Microsoft.CodeAnalysis.Operations.ArgumentKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Add = 1 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.And = 10 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Concatenate = 15 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.ConditionalAnd = 13 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.ConditionalOr = 14 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Divide = 4 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Equals = 16 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.ExclusiveOr = 12 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.GreaterThan = 23 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.GreaterThanOrEqual = 22 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.IntegerDivide = 5 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.LeftShift = 8 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.LessThan = 20 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.LessThanOrEqual = 21 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Like = 24 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Multiply = 3 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.None = 0 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.NotEquals = 18 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.ObjectValueEquals = 17 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.ObjectValueNotEquals = 19 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Or = 11 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Power = 7 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Remainder = 6 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.RightShift = 9 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BinaryOperatorKind.Subtract = 2 -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BranchKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BranchKind.Break = 2 -> Microsoft.CodeAnalysis.Operations.BranchKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BranchKind.Continue = 1 -> Microsoft.CodeAnalysis.Operations.BranchKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BranchKind.GoTo = 3 -> Microsoft.CodeAnalysis.Operations.BranchKind`
* [ ] `Microsoft.CodeAnalysis.Operations.BranchKind.None = 0 -> Microsoft.CodeAnalysis.Operations.BranchKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CaseKind.Default = 4 -> Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CaseKind.None = 0 -> Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CaseKind.Pattern = 5 -> Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CaseKind.Range = 3 -> Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CaseKind.Relational = 2 -> Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CaseKind.SingleValue = 1 -> Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.CommonConversion`
* [ ] `Microsoft.CodeAnalysis.Operations.CommonConversion.Exists.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.CommonConversion.IsIdentity.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.CommonConversion.IsNumeric.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.CommonConversion.IsReference.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.CommonConversion.IsUserDefined.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.CommonConversion.MethodSymbol.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IAddressOfOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAddressOfOperation.Reference.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation.Body.get -> Microsoft.CodeAnalysis.Operations.IBlockOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation.Symbol.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation.Initializers.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IArgumentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IArgumentOperation.ArgumentKind.get -> Microsoft.CodeAnalysis.Operations.ArgumentKind`
* [ ] `Microsoft.CodeAnalysis.Operations.IArgumentOperation.InConversion.get -> Microsoft.CodeAnalysis.Operations.CommonConversion`
* [ ] `Microsoft.CodeAnalysis.Operations.IArgumentOperation.OutConversion.get -> Microsoft.CodeAnalysis.Operations.CommonConversion`
* [ ] `Microsoft.CodeAnalysis.Operations.IArgumentOperation.Parameter.get -> Microsoft.CodeAnalysis.IParameterSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IArgumentOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayCreationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayCreationOperation.DimensionSizes.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayCreationOperation.Initializer.get -> Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation.ArrayReference.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation.Indices.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation.ElementValues.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IAssignmentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAssignmentOperation.Target.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAssignmentOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAwaitOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IAwaitOperation.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation.IsChecked.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation.IsCompareText.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation.IsLifted.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation.LeftOperand.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation.OperatorKind.get -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation.OperatorMethod.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IBinaryOperation.RightOperand.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IBlockOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IBlockOperation.Locals.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>`
* [ ] `Microsoft.CodeAnalysis.Operations.IBlockOperation.Operations.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IBranchOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IBranchOperation.BranchKind.get -> Microsoft.CodeAnalysis.Operations.BranchKind`
* [ ] `Microsoft.CodeAnalysis.Operations.IBranchOperation.Target.get -> Microsoft.CodeAnalysis.ILabelSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ICaseClauseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICaseClauseOperation.CaseKind.get -> Microsoft.CodeAnalysis.Operations.CaseKind`
* [ ] `Microsoft.CodeAnalysis.Operations.ICatchClauseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICatchClauseOperation.ExceptionDeclarationOrExpression.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICatchClauseOperation.ExceptionType.get -> Microsoft.CodeAnalysis.ITypeSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ICatchClauseOperation.Filter.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICatchClauseOperation.Handler.get -> Microsoft.CodeAnalysis.Operations.IBlockOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICatchClauseOperation.Locals.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>`
* [ ] `Microsoft.CodeAnalysis.Operations.ICoalesceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICoalesceOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICoalesceOperation.WhenNull.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICollectionElementInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICollectionElementInitializerOperation.AddMethod.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ICollectionElementInitializerOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.ICollectionElementInitializerOperation.IsDynamic.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation.InConversion.get -> Microsoft.CodeAnalysis.Operations.CommonConversion`
* [ ] `Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation.IsChecked.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation.IsLifted.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation.OperatorKind.get -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation.OperatorMethod.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation.OutConversion.get -> Microsoft.CodeAnalysis.Operations.CommonConversion`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalAccessInstanceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation.WhenNotNull.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalOperation.Condition.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalOperation.IsRef.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalOperation.WhenFalse.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConditionalOperation.WhenTrue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConstantPatternOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConstantPatternOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConversionOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConversionOperation.Conversion.get -> Microsoft.CodeAnalysis.Operations.CommonConversion`
* [ ] `Microsoft.CodeAnalysis.Operations.IConversionOperation.IsChecked.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IConversionOperation.IsTryCast.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IConversionOperation.Operand.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IConversionOperation.OperatorMethod.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation.Expression.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation.DeclaredSymbol.get -> Microsoft.CodeAnalysis.ISymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDefaultCaseClauseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDefaultValueOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation.Target.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation.ContainingType.get -> Microsoft.CodeAnalysis.ITypeSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation.Instance.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation.MemberName.get -> string`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation.TypeArguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation.Initializer.get -> Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IEmptyOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IEndOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation.Adds.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation.EventReference.get -> Microsoft.CodeAnalysis.Operations.IEventReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation.HandlerValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IEventReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IEventReferenceOperation.Event.get -> Microsoft.CodeAnalysis.IEventSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation.InitializedFields.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IFieldSymbol>`
* [ ] `Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation.Field.get -> Microsoft.CodeAnalysis.IFieldSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation.IsDeclaration.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IForEachLoopOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForEachLoopOperation.Collection.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForEachLoopOperation.LoopControlVariable.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForEachLoopOperation.NextVariables.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IForLoopOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForLoopOperation.AtLoopBottom.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IForLoopOperation.Before.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IForLoopOperation.Condition.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForToLoopOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForToLoopOperation.InitialValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForToLoopOperation.LimitValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForToLoopOperation.LoopControlVariable.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IForToLoopOperation.NextVariables.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IForToLoopOperation.StepValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation.IsChecked.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation.IsLifted.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation.IsPostfix.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation.OperatorMethod.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation.Target.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolatedStringContentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation.Parts.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IInterpolatedStringContentOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation.Text.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolationOperation.Alignment.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolationOperation.Expression.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInterpolationOperation.FormatString.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInvalidOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInvocationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInvocationOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IInvocationOperation.Instance.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IInvocationOperation.IsVirtual.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IInvocationOperation.TargetMethod.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IIsPatternOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IIsPatternOperation.Pattern.get -> Microsoft.CodeAnalysis.Operations.IPatternOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IIsPatternOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IIsTypeOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IIsTypeOperation.IsNegated.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IIsTypeOperation.TypeOperand.get -> Microsoft.CodeAnalysis.ITypeSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IIsTypeOperation.ValueOperand.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILabeledOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILabeledOperation.Label.get -> Microsoft.CodeAnalysis.ILabelSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ILabeledOperation.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILiteralOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation.Body.get -> Microsoft.CodeAnalysis.Operations.IBlockOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation.Symbol.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation.IsDeclaration.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation.Local.get -> Microsoft.CodeAnalysis.ILocalSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ILockOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILockOperation.Body.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILockOperation.LockedValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILoopOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILoopOperation.Body.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ILoopOperation.Locals.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>`
* [ ] `Microsoft.CodeAnalysis.Operations.ILoopOperation.LoopKind.get -> Microsoft.CodeAnalysis.Operations.LoopKind`
* [ ] `Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation.InitializedMember.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation.Initializer.get -> Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation.Instance.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IMemberReferenceOperation.Member.get -> Microsoft.CodeAnalysis.ISymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation.IsVirtual.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation.Method.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.INameOfOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.INameOfOperation.Argument.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IObjectCreationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IObjectCreationOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IObjectCreationOperation.Constructor.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IObjectCreationOperation.Initializer.get -> Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation.Initializers.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IOmittedArgumentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation.Parameter.get -> Microsoft.CodeAnalysis.IParameterSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation.Parameter.get -> Microsoft.CodeAnalysis.IParameterSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IParenthesizedOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IParenthesizedOperation.Operand.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation.Guard.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation.Label.get -> Microsoft.CodeAnalysis.ILabelSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation.Pattern.get -> Microsoft.CodeAnalysis.Operations.IPatternOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IPatternOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation.InitializedProperties.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>`
* [ ] `Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation.Property.get -> Microsoft.CodeAnalysis.IPropertySymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IRaiseEventOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IRaiseEventOperation.Arguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IRaiseEventOperation.EventReference.get -> Microsoft.CodeAnalysis.Operations.IEventReferenceOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation.MaximumValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation.MinimumValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation.Relation.get -> Microsoft.CodeAnalysis.Operations.BinaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IReturnOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IReturnOperation.ReturnedValue.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation.IsRef.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISizeOfOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISizeOfOperation.TypeOperand.get -> Microsoft.CodeAnalysis.ITypeSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IStopOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation.Body.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation.Clauses.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICaseClauseOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.ISwitchOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISwitchOperation.Cases.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.ISwitchOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ISymbolInitializerOperation.Value.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IThrowOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IThrowOperation.Exception.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation.Operation.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITryOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITryOperation.Body.get -> Microsoft.CodeAnalysis.Operations.IBlockOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITryOperation.Catches.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.ICatchClauseOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.ITryOperation.Finally.get -> Microsoft.CodeAnalysis.Operations.IBlockOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITupleOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITupleOperation.Elements.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.ITypeOfOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITypeOfOperation.TypeOperand.get -> Microsoft.CodeAnalysis.ITypeSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation.Initializer.get -> Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IUnaryOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IUnaryOperation.IsChecked.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IUnaryOperation.IsLifted.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IUnaryOperation.Operand.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IUnaryOperation.OperatorKind.get -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.IUnaryOperation.OperatorMethod.get -> Microsoft.CodeAnalysis.IMethodSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IUsingOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IUsingOperation.Body.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IUsingOperation.Resources.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation.Declarations.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation.Declarators.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation.Initializer.get -> Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation.IgnoredArguments.get -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation.Initializer.get -> Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation.Symbol.get -> Microsoft.CodeAnalysis.ILocalSymbol`
* [ ] `Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IWhileLoopOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IWhileLoopOperation.Condition.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.IWhileLoopOperation.ConditionIsTop.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IWhileLoopOperation.ConditionIsUntil.get -> bool`
* [ ] `Microsoft.CodeAnalysis.Operations.IWhileLoopOperation.IgnoredCondition.get -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.Operations.LoopKind`
* [ ] `Microsoft.CodeAnalysis.Operations.LoopKind.For = 2 -> Microsoft.CodeAnalysis.Operations.LoopKind`
* [ ] `Microsoft.CodeAnalysis.Operations.LoopKind.ForEach = 4 -> Microsoft.CodeAnalysis.Operations.LoopKind`
* [ ] `Microsoft.CodeAnalysis.Operations.LoopKind.ForTo = 3 -> Microsoft.CodeAnalysis.Operations.LoopKind`
* [ ] `Microsoft.CodeAnalysis.Operations.LoopKind.None = 0 -> Microsoft.CodeAnalysis.Operations.LoopKind`
* [ ] `Microsoft.CodeAnalysis.Operations.LoopKind.While = 1 -> Microsoft.CodeAnalysis.Operations.LoopKind`
* [ ] `Microsoft.CodeAnalysis.Operations.OperationExtensions`
* [ ] `Microsoft.CodeAnalysis.Operations.OperationVisitor`
* [ ] `Microsoft.CodeAnalysis.Operations.OperationVisitor.OperationVisitor() -> void`
* [ ] `Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>`
* [ ] `Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.OperationVisitor() -> void`
* [ ] `Microsoft.CodeAnalysis.Operations.OperationWalker`
* [ ] `Microsoft.CodeAnalysis.Operations.OperationWalker.OperationWalker() -> void`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind.BitwiseNegation = 1 -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind.False = 6 -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind.Minus = 4 -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind.None = 0 -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind.Not = 2 -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind.Plus = 3 -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.Operations.UnaryOperatorKind.True = 5 -> Microsoft.CodeAnalysis.Operations.UnaryOperatorKind`
* [ ] `Microsoft.CodeAnalysis.RefKind.In = 3 -> Microsoft.CodeAnalysis.RefKind`
* [ ] `Microsoft.CodeAnalysis.RefKind.RefReadOnly = 3 -> Microsoft.CodeAnalysis.RefKind`
* [ ] `Microsoft.CodeAnalysis.SemanticModel.GetOperation(Microsoft.CodeAnalysis.SyntaxNode node, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) -> Microsoft.CodeAnalysis.IOperation`
* [ ] `Microsoft.CodeAnalysis.SyntaxList<TNode>.SyntaxList(System.Collections.Generic.IEnumerable<TNode> nodes) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxList<TNode>.SyntaxList(TNode node) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxNodeOrTokenList.SyntaxNodeOrTokenList(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken> nodesAndTokens) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxNodeOrTokenList.SyntaxNodeOrTokenList(params Microsoft.CodeAnalysis.SyntaxNodeOrToken[] nodesAndTokens) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxTokenList.SyntaxTokenList(Microsoft.CodeAnalysis.SyntaxToken token) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxTokenList.SyntaxTokenList(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken> tokens) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxTokenList.SyntaxTokenList(params Microsoft.CodeAnalysis.SyntaxToken[] tokens) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxTriviaList.SyntaxTriviaList(Microsoft.CodeAnalysis.SyntaxTrivia trivia) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxTriviaList.SyntaxTriviaList(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> trivias) -> void`
* [ ] `Microsoft.CodeAnalysis.SyntaxTriviaList.SyntaxTriviaList(params Microsoft.CodeAnalysis.SyntaxTrivia[] trivias) -> void`
* [ ] `override Microsoft.CodeAnalysis.Operations.OperationWalker.DefaultVisit(Microsoft.CodeAnalysis.IOperation operation) -> void`
* [ ] `override Microsoft.CodeAnalysis.Operations.OperationWalker.Visit(Microsoft.CodeAnalysis.IOperation operation) -> void`
* [ ] `override Microsoft.CodeAnalysis.Optional<T>.ToString() -> string`
* [ ] `static Microsoft.CodeAnalysis.Emit.EmitBaseline.CreateInitialBaseline(Microsoft.CodeAnalysis.ModuleMetadata module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation> debugInformationProvider, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StandaloneSignatureHandle> localSignatureProvider, bool hasPortableDebugInformation) -> Microsoft.CodeAnalysis.Emit.EmitBaseline`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.Descendants(this Microsoft.CodeAnalysis.IOperation operation) -> System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.DescendantsAndSelf(this Microsoft.CodeAnalysis.IOperation operation) -> System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetArgumentName(this Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation dynamicOperation, int index) -> string`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetArgumentName(this Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation dynamicOperation, int index) -> string`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetArgumentName(this Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation dynamicOperation, int index) -> string`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetArgumentRefKind(this Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation dynamicOperation, int index) -> Microsoft.CodeAnalysis.RefKind?`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetArgumentRefKind(this Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation dynamicOperation, int index) -> Microsoft.CodeAnalysis.RefKind?`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetArgumentRefKind(this Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation dynamicOperation, int index) -> Microsoft.CodeAnalysis.RefKind?`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetDeclaredVariables(this Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation declarationGroup) -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetDeclaredVariables(this Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation declaration) -> System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ILocalSymbol>`
* [ ] `static Microsoft.CodeAnalysis.Operations.OperationExtensions.GetVariableInitializer(this Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation declarationOperation) -> Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation`
* [ ] `virtual Microsoft.CodeAnalysis.Diagnostics.AnalysisContext.RegisterOperationAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind> operationKinds) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Diagnostics.AnalysisContext.RegisterOperationBlockAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext> action) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Diagnostics.AnalysisContext.RegisterOperationBlockStartAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext> action) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext.RegisterOperationAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind> operationKinds) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext.RegisterOperationBlockAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext> action) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext.RegisterOperationBlockStartAction(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext> action) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.DefaultVisit(Microsoft.CodeAnalysis.IOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.Visit(Microsoft.CodeAnalysis.IOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitAddressOf(Microsoft.CodeAnalysis.Operations.IAddressOfOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitAnonymousFunction(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitAnonymousObjectCreation(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitArgument(Microsoft.CodeAnalysis.Operations.IArgumentOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitArrayCreation(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitArrayElementReference(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitArrayInitializer(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitAwait(Microsoft.CodeAnalysis.Operations.IAwaitOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitBinaryOperator(Microsoft.CodeAnalysis.Operations.IBinaryOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitBlock(Microsoft.CodeAnalysis.Operations.IBlockOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitBranch(Microsoft.CodeAnalysis.Operations.IBranchOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitCatchClause(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitCoalesce(Microsoft.CodeAnalysis.Operations.ICoalesceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitCollectionElementInitializer(Microsoft.CodeAnalysis.Operations.ICollectionElementInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitCompoundAssignment(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitConditional(Microsoft.CodeAnalysis.Operations.IConditionalOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitConditionalAccess(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitConditionalAccessInstance(Microsoft.CodeAnalysis.Operations.IConditionalAccessInstanceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitConstantPattern(Microsoft.CodeAnalysis.Operations.IConstantPatternOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitConversion(Microsoft.CodeAnalysis.Operations.IConversionOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDeclarationExpression(Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDeclarationPattern(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDeconstructionAssignment(Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDefaultCaseClause(Microsoft.CodeAnalysis.Operations.IDefaultCaseClauseOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDefaultValue(Microsoft.CodeAnalysis.Operations.IDefaultValueOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDelegateCreation(Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDynamicIndexerAccess(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDynamicInvocation(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDynamicMemberReference(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitDynamicObjectCreation(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitEmpty(Microsoft.CodeAnalysis.Operations.IEmptyOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitEnd(Microsoft.CodeAnalysis.Operations.IEndOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitEventAssignment(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitEventReference(Microsoft.CodeAnalysis.Operations.IEventReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitExpressionStatement(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitFieldInitializer(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitFieldReference(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitForEachLoop(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitForLoop(Microsoft.CodeAnalysis.Operations.IForLoopOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitForToLoop(Microsoft.CodeAnalysis.Operations.IForToLoopOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitIncrementOrDecrement(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitInstanceReference(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitInterpolatedString(Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitInterpolatedStringText(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitInterpolation(Microsoft.CodeAnalysis.Operations.IInterpolationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitInvalid(Microsoft.CodeAnalysis.Operations.IInvalidOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitInvocation(Microsoft.CodeAnalysis.Operations.IInvocationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitIsPattern(Microsoft.CodeAnalysis.Operations.IIsPatternOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitIsType(Microsoft.CodeAnalysis.Operations.IIsTypeOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitLabeled(Microsoft.CodeAnalysis.Operations.ILabeledOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitLiteral(Microsoft.CodeAnalysis.Operations.ILiteralOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitLocalFunction(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitLocalReference(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitLock(Microsoft.CodeAnalysis.Operations.ILockOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitMemberInitializer(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitMethodReference(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitNameOf(Microsoft.CodeAnalysis.Operations.INameOfOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitObjectCreation(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitObjectOrCollectionInitializer(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitOmittedArgument(Microsoft.CodeAnalysis.Operations.IOmittedArgumentOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitParameterInitializer(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitParameterReference(Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitParenthesized(Microsoft.CodeAnalysis.Operations.IParenthesizedOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitPatternCaseClause(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitPropertyInitializer(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitPropertyReference(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitRaiseEvent(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitRangeCaseClause(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitRelationalCaseClause(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitReturn(Microsoft.CodeAnalysis.Operations.IReturnOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitSimpleAssignment(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitSingleValueCaseClause(Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitSizeOf(Microsoft.CodeAnalysis.Operations.ISizeOfOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitStop(Microsoft.CodeAnalysis.Operations.IStopOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitSwitch(Microsoft.CodeAnalysis.Operations.ISwitchOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitSwitchCase(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitThrow(Microsoft.CodeAnalysis.Operations.IThrowOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitTranslatedQuery(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitTry(Microsoft.CodeAnalysis.Operations.ITryOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitTuple(Microsoft.CodeAnalysis.Operations.ITupleOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitTypeOf(Microsoft.CodeAnalysis.Operations.ITypeOfOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitTypeParameterObjectCreation(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitUnaryOperator(Microsoft.CodeAnalysis.Operations.IUnaryOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitUsing(Microsoft.CodeAnalysis.Operations.IUsingOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitVariableDeclaration(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitVariableDeclarationGroup(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitVariableDeclarator(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitVariableInitializer(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor.VisitWhileLoop(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation operation) -> void`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.DefaultVisit(Microsoft.CodeAnalysis.IOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.Visit(Microsoft.CodeAnalysis.IOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitAddressOf(Microsoft.CodeAnalysis.Operations.IAddressOfOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitAnonymousFunction(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitAnonymousObjectCreation(Microsoft.CodeAnalysis.Operations.IAnonymousObjectCreationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitArgument(Microsoft.CodeAnalysis.Operations.IArgumentOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitArrayCreation(Microsoft.CodeAnalysis.Operations.IArrayCreationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitArrayElementReference(Microsoft.CodeAnalysis.Operations.IArrayElementReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitArrayInitializer(Microsoft.CodeAnalysis.Operations.IArrayInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitAwait(Microsoft.CodeAnalysis.Operations.IAwaitOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitBinaryOperator(Microsoft.CodeAnalysis.Operations.IBinaryOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitBlock(Microsoft.CodeAnalysis.Operations.IBlockOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitBranch(Microsoft.CodeAnalysis.Operations.IBranchOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitCatchClause(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitCoalesce(Microsoft.CodeAnalysis.Operations.ICoalesceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitCollectionElementInitializer(Microsoft.CodeAnalysis.Operations.ICollectionElementInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitCompoundAssignment(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitConditional(Microsoft.CodeAnalysis.Operations.IConditionalOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitConditionalAccess(Microsoft.CodeAnalysis.Operations.IConditionalAccessOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitConditionalAccessInstance(Microsoft.CodeAnalysis.Operations.IConditionalAccessInstanceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitConstantPattern(Microsoft.CodeAnalysis.Operations.IConstantPatternOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitConversion(Microsoft.CodeAnalysis.Operations.IConversionOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDeclarationExpression(Microsoft.CodeAnalysis.Operations.IDeclarationExpressionOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDeclarationPattern(Microsoft.CodeAnalysis.Operations.IDeclarationPatternOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDeconstructionAssignment(Microsoft.CodeAnalysis.Operations.IDeconstructionAssignmentOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDefaultCaseClause(Microsoft.CodeAnalysis.Operations.IDefaultCaseClauseOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDefaultValue(Microsoft.CodeAnalysis.Operations.IDefaultValueOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDelegateCreation(Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDynamicIndexerAccess(Microsoft.CodeAnalysis.Operations.IDynamicIndexerAccessOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDynamicInvocation(Microsoft.CodeAnalysis.Operations.IDynamicInvocationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDynamicMemberReference(Microsoft.CodeAnalysis.Operations.IDynamicMemberReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitDynamicObjectCreation(Microsoft.CodeAnalysis.Operations.IDynamicObjectCreationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitEmpty(Microsoft.CodeAnalysis.Operations.IEmptyOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitEnd(Microsoft.CodeAnalysis.Operations.IEndOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitEventAssignment(Microsoft.CodeAnalysis.Operations.IEventAssignmentOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitEventReference(Microsoft.CodeAnalysis.Operations.IEventReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitExpressionStatement(Microsoft.CodeAnalysis.Operations.IExpressionStatementOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitFieldInitializer(Microsoft.CodeAnalysis.Operations.IFieldInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitFieldReference(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitForEachLoop(Microsoft.CodeAnalysis.Operations.IForEachLoopOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitForLoop(Microsoft.CodeAnalysis.Operations.IForLoopOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitForToLoop(Microsoft.CodeAnalysis.Operations.IForToLoopOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitIncrementOrDecrement(Microsoft.CodeAnalysis.Operations.IIncrementOrDecrementOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitInstanceReference(Microsoft.CodeAnalysis.Operations.IInstanceReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitInterpolatedString(Microsoft.CodeAnalysis.Operations.IInterpolatedStringOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitInterpolatedStringText(Microsoft.CodeAnalysis.Operations.IInterpolatedStringTextOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitInterpolation(Microsoft.CodeAnalysis.Operations.IInterpolationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitInvalid(Microsoft.CodeAnalysis.Operations.IInvalidOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitInvocation(Microsoft.CodeAnalysis.Operations.IInvocationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitIsPattern(Microsoft.CodeAnalysis.Operations.IIsPatternOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitIsType(Microsoft.CodeAnalysis.Operations.IIsTypeOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitLabeled(Microsoft.CodeAnalysis.Operations.ILabeledOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitLiteral(Microsoft.CodeAnalysis.Operations.ILiteralOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitLocalFunction(Microsoft.CodeAnalysis.Operations.ILocalFunctionOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitLocalReference(Microsoft.CodeAnalysis.Operations.ILocalReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitLock(Microsoft.CodeAnalysis.Operations.ILockOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitMemberInitializer(Microsoft.CodeAnalysis.Operations.IMemberInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitMethodReference(Microsoft.CodeAnalysis.Operations.IMethodReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitNameOf(Microsoft.CodeAnalysis.Operations.INameOfOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitObjectCreation(Microsoft.CodeAnalysis.Operations.IObjectCreationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitObjectOrCollectionInitializer(Microsoft.CodeAnalysis.Operations.IObjectOrCollectionInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitOmittedArgument(Microsoft.CodeAnalysis.Operations.IOmittedArgumentOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitParameterInitializer(Microsoft.CodeAnalysis.Operations.IParameterInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitParameterReference(Microsoft.CodeAnalysis.Operations.IParameterReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitParenthesized(Microsoft.CodeAnalysis.Operations.IParenthesizedOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitPatternCaseClause(Microsoft.CodeAnalysis.Operations.IPatternCaseClauseOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitPropertyInitializer(Microsoft.CodeAnalysis.Operations.IPropertyInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitPropertyReference(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitRaiseEvent(Microsoft.CodeAnalysis.Operations.IRaiseEventOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitRangeCaseClause(Microsoft.CodeAnalysis.Operations.IRangeCaseClauseOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitRelationalCaseClause(Microsoft.CodeAnalysis.Operations.IRelationalCaseClauseOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitReturn(Microsoft.CodeAnalysis.Operations.IReturnOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitSimpleAssignment(Microsoft.CodeAnalysis.Operations.ISimpleAssignmentOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitSingleValueCaseClause(Microsoft.CodeAnalysis.Operations.ISingleValueCaseClauseOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitSizeOf(Microsoft.CodeAnalysis.Operations.ISizeOfOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitStop(Microsoft.CodeAnalysis.Operations.IStopOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitSwitch(Microsoft.CodeAnalysis.Operations.ISwitchOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitSwitchCase(Microsoft.CodeAnalysis.Operations.ISwitchCaseOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitThrow(Microsoft.CodeAnalysis.Operations.IThrowOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitTranslatedQuery(Microsoft.CodeAnalysis.Operations.ITranslatedQueryOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitTry(Microsoft.CodeAnalysis.Operations.ITryOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitTuple(Microsoft.CodeAnalysis.Operations.ITupleOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitTypeOf(Microsoft.CodeAnalysis.Operations.ITypeOfOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitTypeParameterObjectCreation(Microsoft.CodeAnalysis.Operations.ITypeParameterObjectCreationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitUnaryOperator(Microsoft.CodeAnalysis.Operations.IUnaryOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitUsing(Microsoft.CodeAnalysis.Operations.IUsingOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitVariableDeclaration(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitVariableDeclarationGroup(Microsoft.CodeAnalysis.Operations.IVariableDeclarationGroupOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitVariableDeclarator(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitVariableInitializer(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation operation, TArgument argument) -> TResult`
* [ ] `virtual Microsoft.CodeAnalysis.Operations.OperationVisitor<TArgument, TResult>.VisitWhileLoop(Microsoft.CodeAnalysis.Operations.IWhileLoopOperation operation, TArgument argument) -> TResult`

* [ ] `Microsoft.CodeAnalysis.CSharp.Conversion.IsStackAlloc.get -> bool`
* [ ] `Microsoft.CodeAnalysis.CSharp.Conversion.ToCommonConversion() -> Microsoft.CodeAnalysis.Operations.CommonConversion`
* [ ] `static Microsoft.CodeAnalysis.CSharp.CSharpExtensions.GetConversion(this Microsoft.CodeAnalysis.Operations.IConversionOperation conversionExpression) -> Microsoft.CodeAnalysis.CSharp.Conversion`
* [ ] `static Microsoft.CodeAnalysis.CSharp.CSharpExtensions.GetInConversion(this Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation compoundAssignment) -> Microsoft.CodeAnalysis.CSharp.Conversion`
* [ ] `static Microsoft.CodeAnalysis.CSharp.CSharpExtensions.GetOutConversion(this Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation compoundAssignment) -> Microsoft.CodeAnalysis.CSharp.Conversion`

## Syntax

* [x] `Microsoft.CodeAnalysis.CSharp.LanguageVersion.CSharp7_2 = 702 -> Microsoft.CodeAnalysis.CSharp.LanguageVersion`
* [x] `Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax.ReadOnlyKeyword.get -> Microsoft.CodeAnalysis.SyntaxToken`
* [ ] `Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax.Update(Microsoft.CodeAnalysis.SyntaxToken refKeyword, Microsoft.CodeAnalysis.SyntaxToken readOnlyKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax type) -> Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax`
* [x] `Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax.WithReadOnlyKeyword(Microsoft.CodeAnalysis.SyntaxToken readOnlyKeyword) -> Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax`
* [ ] `static Microsoft.CodeAnalysis.CSharp.SyntaxFactory.RefType(Microsoft.CodeAnalysis.SyntaxToken refKeyword, Microsoft.CodeAnalysis.SyntaxToken readOnlyKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax type) -> Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax`
