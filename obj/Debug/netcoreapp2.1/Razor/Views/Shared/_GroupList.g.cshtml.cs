#pragma checksum "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcbcafa11631bbca14f682bb3bc69c80fc6bea01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GroupList), @"mvc.1.0.view", @"/Views/Shared/_GroupList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GroupList.cshtml", typeof(AspNetCore.Views_Shared__GroupList))]
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
#line 1 "D:\CC\AspCore\Students\StudentsPub\Views\_ViewImports.cshtml"
using Students;

#line default
#line hidden
#line 2 "D:\CC\AspCore\Students\StudentsPub\Views\_ViewImports.cshtml"
using Students.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcbcafa11631bbca14f682bb3bc69c80fc6bea01", @"/Views/Shared/_GroupList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7df94618740a86f3e5e392578a1f7964162558e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GroupList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Students.Models.Group>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Groups", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 168, true);
            WriteLiteral("\r\n<div class=\"list-div\">\r\n    <table class=\"table-condensed\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Имя группы</th>\r\n            <th>Активность</th>\r\n");
            EndContext();
#line 9 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(275, 35, true);
            WriteLiteral("                <th>Посмотреть</th>");
            EndContext();
#line 11 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                                   }

#line default
#line hidden
            BeginContext(313, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
             if (ViewBag.IsAdmin)
            {

#line default
#line hidden
            BeginContext(365, 74, true);
            WriteLiteral("                <th>Редактировать</th>\r\n                <th>Удалить</th>\r\n");
            EndContext();
#line 17 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
            }

#line default
#line hidden
            BeginContext(454, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 19 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
         foreach (var group in Model)
        {

#line default
#line hidden
            BeginContext(519, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(558, 8, false);
#line 22 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
               Write(group.Id);

#line default
#line hidden
            EndContext();
            BeginContext(566, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(594, 10, false);
#line 23 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
               Write(group.Name);

#line default
#line hidden
            EndContext();
            BeginContext(604, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 24 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                 if (group.Active)
                {

#line default
#line hidden
            BeginContext(666, 38, true);
            WriteLiteral("                    <td>Активна</td>\r\n");
            EndContext();
#line 27 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                }
                else { 

#line default
#line hidden
            BeginContext(748, 41, true);
            WriteLiteral("                    <td>Не активна</td>\r\n");
            EndContext();
#line 30 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                }

#line default
#line hidden
            BeginContext(808, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 31 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(880, 122, true);
            WriteLiteral("                    <td>\r\n                        <button type=\"button\" class=\"btn-success\">\r\n                            ");
            EndContext();
            BeginContext(1002, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "988f33d75a4146c591bac972db4f1ea3", async() => {
                BeginContext(1095, 74, true);
                WriteLiteral("\r\n                                Посмотреть\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                                                                                                  WriteLiteral(group.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1173, 64, true);
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n");
            EndContext();
#line 40 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                }

#line default
#line hidden
            BeginContext(1256, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 41 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                 if (ViewBag.IsAdmin)
                {

#line default
#line hidden
            BeginContext(1314, 122, true);
            WriteLiteral("                    <td>\r\n                        <button type=\"button\" class=\"btn-warning\">\r\n                            ");
            EndContext();
            BeginContext(1436, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310b73b1c5904f4cad18f4d7af9e9f90", async() => {
                BeginContext(1526, 77, true);
                WriteLiteral("\r\n                                Редактировать\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                                                                                               WriteLiteral(group.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1607, 185, true);
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"btn-danger\">\r\n                            ");
            EndContext();
            BeginContext(1792, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe40d4e67794a0594e976f6a3339807", async() => {
                BeginContext(1883, 71, true);
                WriteLiteral("\r\n                                Удалить\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                                                                                                WriteLiteral(group.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1958, 64, true);
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n");
            EndContext();
#line 57 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
                }

#line default
#line hidden
            BeginContext(2041, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 59 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
        }

#line default
#line hidden
            BeginContext(2071, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 61 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
     if (ViewBag.IsAdmin)
    {

#line default
#line hidden
            BeginContext(2119, 64, true);
            WriteLiteral("        <button type=\"button\" class=\"btn-primary\">\r\n            ");
            EndContext();
            BeginContext(2183, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eaed715d38345eba4c132fedb9af8e8", async() => {
                BeginContext(2250, 7, true);
                WriteLiteral("Создать");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2261, 21, true);
            WriteLiteral("\r\n        </button>\r\n");
            EndContext();
#line 66 "D:\CC\AspCore\Students\StudentsPub\Views\Shared\_GroupList.cshtml"
    }

#line default
#line hidden
            BeginContext(2289, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Students.Models.Group>> Html { get; private set; }
    }
}
#pragma warning restore 1591
