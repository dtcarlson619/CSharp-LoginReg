#pragma checksum "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\LoginReg\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82b8fba6ca9c29f3fa53fcbb001c027785a33d56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\LoginReg\Views\_ViewImports.cshtml"
using LoginReg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\LoginReg\Views\_ViewImports.cshtml"
using LoginReg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82b8fba6ca9c29f3fa53fcbb001c027785a33d56", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cffb413b3ff31940133525c56529196ca370a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\LoginReg\Views\Home\Success.cshtml"
  
    ViewData["Title"] = "Success Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-3 mb-3"">
    <a class=""col-12 text-right"" href=""logout""><input type=""button"" value=""Logout"" class=""btn btn-primary""></a>
</div>
<div class=""row mb-3"">
    <h1 class=""col-12 text-center text-success"">S U C C E S S </h1>
</div>
<div class=""text-center"">
    <h2>Hello, ");
#nullable restore
#line 13 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\LoginReg\Views\Home\Success.cshtml"
          Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
