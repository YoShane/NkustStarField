#pragma checksum "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92eab6d00c04a8a2ec612de9b1a088447356e862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BorrowOrders_Index), @"mvc.1.0.view", @"/Views/BorrowOrders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BorrowOrders/Index.cshtml", typeof(AspNetCore.Views_BorrowOrders_Index))]
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
#line 1 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\_ViewImports.cshtml"
using EquipmentManagement;

#line default
#line hidden
#line 2 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\_ViewImports.cshtml"
using EquipmentManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92eab6d00c04a8a2ec612de9b1a088447356e862", @"/Views/BorrowOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2251c7943319063494df12f7cbe907de7125c9", @"/Views/_ViewImports.cshtml")]
    public class Views_BorrowOrders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EquipmentManagement.Models.BorrowOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
  
    ViewData["Title"] = "訂單查詢";

#line default
#line hidden
            BeginContext(97, 60, true);
            WriteLiteral("\n            <h1>租借紀錄</h1>\n\n            <p>\n                ");
            EndContext();
            BeginContext(157, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92eab6d00c04a8a2ec612de9b1a088447356e8624864", async() => {
                BeginContext(180, 6, true);
                WriteLiteral("建立新的一筆");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 158, true);
            WriteLiteral("\n            </p>\n            <table class=\"table\">\n                <thead>\n                    <tr>\n                        <th>\n                            ");
            EndContext();
            BeginContext(349, 44, false);
#line 16 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(393, 88, true);
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
            EndContext();
            BeginContext(482, 47, false);
#line 19 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Borrow_time));

#line default
#line hidden
            EndContext();
            BeginContext(529, 88, true);
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
            EndContext();
            BeginContext(618, 48, false);
#line 22 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Restore_time));

#line default
#line hidden
            EndContext();
            BeginContext(666, 88, true);
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
            EndContext();
            BeginContext(755, 42, false);
#line 25 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(797, 140, true);
            WriteLiteral("\n                        </th>\n                        <th></th>\n                    </tr>\n                </thead>\n                <tbody>\n");
            EndContext();
#line 31 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(988, 94, true);
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1083, 43, false);
#line 34 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1227, 46, false);
#line 37 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Borrow_time));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1374, 47, false);
#line 40 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Restore_time));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1522, 41, false);
#line 43 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1663, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92eab6d00c04a8a2ec612de9b1a088447356e86210765", async() => {
                BeginContext(1708, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                                                       WriteLiteral(item.Id);

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
            BeginContext(1716, 35, true);
            WriteLiteral(" |\n                                ");
            EndContext();
            BeginContext(1751, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92eab6d00c04a8a2ec612de9b1a088447356e86213160", async() => {
                BeginContext(1799, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                                                          WriteLiteral(item.Id);

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
            BeginContext(1810, 35, true);
            WriteLiteral(" |\n                                ");
            EndContext();
            BeginContext(1845, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92eab6d00c04a8a2ec612de9b1a088447356e86215561", async() => {
                BeginContext(1892, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                                                         WriteLiteral(item.Id);

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
            BeginContext(1902, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 51 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1989, 45, true);
            WriteLiteral("                </tbody>\n            </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EquipmentManagement.Models.BorrowOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
