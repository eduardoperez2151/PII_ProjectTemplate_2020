# Qué hay configurado en esta plantilla

1. Un proyecto de biblioteca (creado con [`dotnet new classlib`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\Library`.
2. Un proyecto de aplicación de consola (creado con [`dotnet new console`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\Program`.
3. Un proyecto de prueba en [NUnit](https://nunit.org/) (creado con [`dotnet new nunit`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22))) en la carpeta `test\Library.Test`.
4. Configuración de [DocFx](https://dotnet.github.io/docfx/) para generación de sitio web de documentación en la carpeta `docs`.
5. Análisis estático con [FxCop](https://github.com/dotnet/roslyn-analyzers/blob/master/README.md) para el proyectos de biblioteca.
6. Análisis de estilo con [StyleCop](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/README.md) en el proyecto de biblioteca.
7. Tareas preconfiguradas para compilar y ejecutar los proyectos de consola y de pruebas desde VSCode en la carpeta `.vscode`

## Convenciones

[Convenciones de código en C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

[Convenciones de nombres en C#](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

## Dónde encontrar información sobre los errores/avisos al compilar

[C# Compiler Errors (CS*)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/)

[FxCop Analyzer Warnings (CA*)](https://docs.microsoft.com/en-us/visualstudio/code-quality/code-analysis-warnings-for-managed-code-by-checkid?view=vs-2019)

[StyleCop Analyzer Warnings (SA*)](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/DOCUMENTATION.md)

# Cómo deshabilitar temporalmente los avisos al compilar

## FxCop Analyzer

Comentar la línea `<PackageReference Include="Microsoft.CodeAnalysis.FxCopAnalyzers" Version="2.9.8" />` en los archivos de proyecto (`*.csproj`)

## StyleCop Analyzer

Comentar la línea `<PackageReference Include="StyleCop.Analyzers" Version="1.1.118" />` en los archivos de proyecto (`*.csproj`)
