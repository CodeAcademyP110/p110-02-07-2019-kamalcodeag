#pragma checksum "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af09d01d7e28111674d882b76d0b0d5da97ce72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af09d01d7e28111674d882b76d0b0d5da97ce72", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication4.ViewModel.HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 251, true);
            WriteLiteral("\r\n<h2>Students</h2>\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Student Name</th>\r\n            <th scope=\"col\">Group</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
         foreach (var item in Model.Students)
        {

#line default
#line hidden
            BeginContext(438, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(489, 7, false);
#line 20 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(496, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 547, "\"", 576, 2);
            WriteAttributeValue("", 554, "/student/info/", 554, 14, true);
#line 22 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
WriteAttributeValue("", 568, item.Id, 568, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(577, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(605, 9, false);
#line 23 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(614, 71, true);
            WriteLiteral("\r\n                    </a>\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(686, 12, false);
#line 26 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
               Write(item.GroupId);

#line default
#line hidden
            EndContext();
            BeginContext(698, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(735, 239, true);
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n<h2>Groups</h2>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Group Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
         foreach (var item in Model.Groups)
        {

#line default
#line hidden
            BeginContext(1030, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(1081, 7, false);
#line 48 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1117, "\"", 1144, 2);
            WriteAttributeValue("", 1124, "/group/info/", 1124, 12, true);
#line 49 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
WriteAttributeValue("", 1136, item.Id, 1136, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1145, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1147, 9, false);
#line 49 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 30, true);
            WriteLiteral("</a></td>\r\n            </tr>\r\n");
            EndContext();
#line 51 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1197, 246, true);
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n\r\n<h2>Profession</h2>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Profession Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 67 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
         foreach (var item in Model.Professions)
        {

#line default
#line hidden
            BeginContext(1504, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(1555, 7, false);
#line 70 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1590, 9, false);
#line 71 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 73 "D:\Programming\Other\ASP.NET\02.07.2019(Model,View Model)\Home\WebApplication4(Yasin)\WebApplication4\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1636, 26, true);
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication4.ViewModel.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
