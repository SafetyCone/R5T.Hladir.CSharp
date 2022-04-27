using System;using R5T.T0064;


namespace R5T.Hladir.CSharp
{[ServiceDefinitionMarker]
    public interface ICSharpVisualStudioProjectFileNameConventions:IServiceDefinition
    {
        string GetCSharpProjectName(string projectFileName);
        string GetCSharpProjectFileName(string projectName);
    }
}
