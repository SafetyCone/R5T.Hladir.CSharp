using System;


namespace R5T.Hladir.CSharp
{
    public interface ICSharpVisualStudioProjectFileNameConventions
    {
        string GetCSharpProjectName(string projectFileName);
        string GetCSharpProjectFileName(string projectName);
    }
}
