#pragma checksum "C:\Users\paulo.mariano.JJANOX\Documents\GitHub\PowerBI-Developer-Samples\.NET Core\Embed for your organization\UserOwnsData\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f210573004a64f86834f23d654f96132b2f8b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 8 "C:\Users\paulo.mariano.JJANOX\Documents\GitHub\PowerBI-Developer-Samples\.NET Core\Embed for your organization\UserOwnsData\Views\_ViewImports.cshtml"
using UserOwnsData;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f210573004a64f86834f23d654f96132b2f8b0a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4d56a6fdfb8be263c37c672aa618936052f4cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"overlay\">\r\n    <div class=\"signin-container\">\r\n        <p>Sign in to Power BI</p>\r\n        <button class=\"sign-in\"");
            BeginWriteAttribute("onclick", " onclick=\"", 363, "\"", 417, 3);
            WriteAttributeValue("", 373, "location.href=\'", 373, 15, true);
#nullable restore
#line 11 "C:\Users\paulo.mariano.JJANOX\Documents\GitHub\PowerBI-Developer-Samples\.NET Core\Embed for your organization\UserOwnsData\Views\Home\Index.cshtml"
WriteAttributeValue("", 388, Url.Action("Embed", "Home"), 388, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 416, "\'", 416, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Sign in</button>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
