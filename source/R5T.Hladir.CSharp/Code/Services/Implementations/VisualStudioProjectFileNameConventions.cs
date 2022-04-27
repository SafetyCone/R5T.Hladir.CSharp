using System;using R5T.T0064;


namespace R5T.Hladir.CSharp
{[ServiceImplementationMarker]
    public class VisualStudioProjectFileNameConventions : IVisualStudioProjectFileNameConventions,IServiceImplementation
    {
        private ICSharpVisualStudioProjectFileNameConventions CSharpVisualStudioProjectFileNameConventions { get; }


        public VisualStudioProjectFileNameConventions(ICSharpVisualStudioProjectFileNameConventions cSharpVisualStudioProjectFileNameConventions)
        {
            this.CSharpVisualStudioProjectFileNameConventions = cSharpVisualStudioProjectFileNameConventions;
        }

        public string GetProjectFileName(string projectName)
        {
            var projectFileName = this.CSharpVisualStudioProjectFileNameConventions.GetCSharpProjectFileName(projectName);
            return projectFileName;
        }

        public string GetProjectName(string projectFileName)
        {
            var projectName = this.CSharpVisualStudioProjectFileNameConventions.GetCSharpProjectName(projectFileName);
            return projectName;
        }
    }
}
