using System;


namespace R5T.Hladir.CSharp
{
    public class VisualStudioProjectFileNameConventions : IVisualStudioProjectFileNameConventions
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
