using System;

using R5T.Lombardy;using R5T.T0064;


namespace R5T.Hladir.CSharp
{[ServiceImplementationMarker]
    public class CSharpVisualStudioProjectFileNameConventions : ICSharpVisualStudioProjectFileNameConventions,IServiceImplementation
    {
        private IFileNameOperator FileNameOperator { get; }


        public CSharpVisualStudioProjectFileNameConventions(IFileNameOperator fileNameOperator)
        {
            this.FileNameOperator = fileNameOperator;
        }

        public string GetCSharpProjectFileName(string projectName)
        {
            // The project file name is just the project name, suffixed with the C# project file extension.
            // TODO, check project name for any non-standard characters.
            var projectFileName = this.FileNameOperator.GetFileName(projectName, Constants.CSharpProjectFileExtension);
            return projectFileName;
        }

        public string GetCSharpProjectName(string projectFileName)
        {
            // The project name is just the project file name without the C# project file extension.
            var projectName = this.FileNameOperator.GetFileNameWithoutExtension(projectFileName);
            return projectName;
        }
    }
}
