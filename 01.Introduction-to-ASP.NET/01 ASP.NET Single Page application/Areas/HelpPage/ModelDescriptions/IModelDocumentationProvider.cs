using System;
using System.Reflection;

namespace _01_ASP.NET_Single_Page_application.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}