#pragma checksum "D:\CC\AspCore\Students\Students\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ff041575396b6567f53df6eb37ca2a1826d71d"
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
#line 1 "D:\CC\AspCore\Students\Students\Views\_ViewImports.cshtml"
using Students;

#line default
#line hidden
#line 2 "D:\CC\AspCore\Students\Students\Views\_ViewImports.cshtml"
using Students.Models;

#line default
#line hidden
#line 1 "D:\CC\AspCore\Students\Students\Views\Home\Index.cshtml"
using Students.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ff041575396b6567f53df6eb37ca2a1826d71d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7df94618740a86f3e5e392578a1f7964162558e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\CC\AspCore\Students\Students\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 98, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"page-header\" style=\"text-align : center\">\r\n        Студенты\r\n    </div>\r\n");
            EndContext();
#line 10 "D:\CC\AspCore\Students\Students\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_StudentsList", ViewBag.Students as List<Student>);

#line default
#line hidden
            BeginContext(256, 87, true);
            WriteLiteral("    <div class=\"page-header\" style=\"text-align : center\">\r\n        Группы\r\n    </div>\r\n");
            EndContext();
#line 14 "D:\CC\AspCore\Students\Students\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_GroupList", ViewBag.Groups as List<Group>);

#line default
#line hidden
            BeginContext(427, 85, true);
            WriteLiteral("    <div class=\"page-header\" style=\"text-align : center\">\r\n        Пары\r\n    </div>\r\n");
            EndContext();
#line 18 "D:\CC\AspCore\Students\Students\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_PairsList", ViewBag.Pairs as List<Pair>);

#line default
#line hidden
            BeginContext(594, 93, true);
            WriteLiteral("    <div class=\"page-header\" style=\"text-align : center\">\r\n        Профессора\r\n    </div>\r\n\r\n");
            EndContext();
#line 23 "D:\CC\AspCore\Students\Students\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_ProfessorsList", ViewBag.Professors as List<Professor>);

#line default
#line hidden
            BeginContext(784, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
