#pragma checksum "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Student\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "022d4808ecd6e2fea8c472b60519c12e90ab23cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Info), @"mvc.1.0.view", @"/Views/Student/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Info.cshtml", typeof(AspNetCore.Views_Student_Info))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022d4808ecd6e2fea8c472b60519c12e90ab23cd", @"/Views/Student/Info.cshtml")]
    public class Views_Student_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication4.Models.StudentItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Student\Info.cshtml"
  
    ViewData["Title"] = "Info";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 29, true);
            WriteLiteral("\r\n<h2>Info</h2>\r\n\r\n<p>Name : ");
            EndContext();
            BeginContext(160, 8, false);
#line 9 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Student\Info.cshtml"
     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(168, 24, true);
            WriteLiteral("</p>\r\n<hr />\r\n<p>Name : ");
            EndContext();
            BeginContext(193, 10, false);
#line 11 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Student\Info.cshtml"
     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(203, 25, true);
            WriteLiteral("</p>\r\n<hr />\r\n<p>Group : ");
            EndContext();
            BeginContext(229, 17, false);
#line 13 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Student\Info.cshtml"
      Write(ViewBag.GroupName);

#line default
#line hidden
            EndContext();
            BeginContext(246, 60, true);
            WriteLiteral("</p>\r\n\r\n\r\n<a href=\"/\" class=\"btn btn-primary\">Geri qayit</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication4.Models.StudentItem> Html { get; private set; }
    }
}
#pragma warning restore 1591