#pragma checksum "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf25ba83025ba5a6535e82af2e28a2a65a6ac554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BorrowOrders_Details), @"mvc.1.0.view", @"/Views/BorrowOrders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BorrowOrders/Details.cshtml", typeof(AspNetCore.Views_BorrowOrders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf25ba83025ba5a6535e82af2e28a2a65a6ac554", @"/Views/BorrowOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eafb0ab7b065fb2e3bbc3e4c414fbe958707142e", @"/Views/_ViewImports.cshtml")]
    public class Views_BorrowOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EquipmentManagement.Models.BorrowOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    int totalPrice = 0;

#line default
#line hidden
            BeginContext(117, 154, true);
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\"min-height: 22em\">\r\n    <main role=\"main\" class=\"pb-1\">\r\n        <h1>租借明細</h1>\r\n        <p>\r\n            <a href=\"#\">編號-");
            EndContext();
            BeginContext(272, 74, false);
#line 13 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                      Write(Html.Raw(string.Format("{0:yyyyMMdd}{1:00}", Model.Borrow_time, Model.Id)));

#line default
#line hidden
            EndContext();
            BeginContext(346, 62, true);
            WriteLiteral("</a>\r\n        </p>\r\n        <hr />\r\n        <dl class=\"row\">\r\n");
            EndContext();
#line 17 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
             if (Model.Member.Name != "") {

#line default
#line hidden
            BeginContext(453, 59, true);
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(513, 47, false);
#line 19 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Member.Name));

#line default
#line hidden
            EndContext();
            BeginContext(560, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(646, 43, false);
#line 22 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
               Write(Html.DisplayFor(model => model.Member.Name));

#line default
#line hidden
            EndContext();
            BeginContext(689, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 24 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(729, 51, true);
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(781, 44, false);
#line 26 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(825, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(899, 40, false);
#line 29 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
           Write(Html.DisplayFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(939, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 31 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
             if (Model.Member.Hot_mail != Model.Stu_mail && Model.Member.Hot_mail != "") {

#line default
#line hidden
            BeginContext(1052, 59, true);
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1112, 51, false);
#line 33 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Member.Hot_mail));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1249, 47, false);
#line 36 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
               Write(Html.DisplayFor(model => model.Member.Hot_mail));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 38 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1336, 53, true);
            WriteLiteral("\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1390, 48, false);
#line 41 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Restore_time));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1512, 44, false);
#line 44 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
           Write(Html.DisplayFor(model => model.Restore_time));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1629, 49, false);
#line 47 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Restore_state));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1752, 45, false);
#line 50 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
           Write(Html.DisplayFor(model => model.Restore_state));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 378, true);
            WriteLiteral(@"
            </dd>
        </dl>


        <table class=""myTable"">
            <thead>
                <tr>
                    <th></th>
                    <th>名稱</th>
                    <th>價格</th>
                    <th>數量</th>
                    <th>小計</th>
                    <th>備註</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 67 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                 foreach (var item in Model.BorrowRecords) {
                    totalPrice += item.Price;

#line default
#line hidden
            BeginContext(2284, 63, true);
            WriteLiteral("                <tr>\r\n                    <td align=\"center\">\r\n");
            EndContext();
#line 71 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                     if(item.Equipment.Img != null) {

#line default
#line hidden
            BeginContext(2387, 85, true);
            WriteLiteral("                        <div class=\"img-thumbnail\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2472, "\"", 2546, 3);
            WriteAttributeValue("", 2478, "data:image/png;base64,", 2478, 22, true);
#line 73 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
WriteAttributeValue("", 2500, Convert.ToBase64String(item.Equipment.Img), 2500, 45, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2545, "", 2546, 1, true);
            EndWriteAttribute();
            BeginContext(2547, 46, true);
            WriteLiteral(" width=\"40\">\r\n                        </div>\r\n");
            EndContext();
#line 75 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
						}

#line default
#line hidden
            BeginContext(2602, 51, true);
            WriteLiteral("                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(2654, 29, false);
#line 77 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                   Write(Html.Raw(item.Equipment.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2683, 35, true);
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n");
            EndContext();
#line 80 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                         if (Model.Member.Member_fee) {
                            

#line default
#line hidden
            BeginContext(2804, 37, false);
#line 81 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                       Write(Html.Raw(item.Equipment.Price_member));

#line default
#line hidden
            EndContext();
#line 81 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                  ;
                        } else {
                            

#line default
#line hidden
            BeginContext(2907, 41, false);
#line 83 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                       Write(Html.Raw(item.Equipment.Price_non_member));

#line default
#line hidden
            EndContext();
#line 83 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                      ;
                        }

#line default
#line hidden
            BeginContext(2978, 51, true);
            WriteLiteral("                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(3030, 23, false);
#line 86 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                   Write(Html.Raw(item.Quantuty));

#line default
#line hidden
            EndContext();
            BeginContext(3053, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3085, 20, false);
#line 87 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                   Write(Html.Raw(item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3105, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3137, 21, false);
#line 88 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                   Write(Html.Raw(item.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(3158, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 90 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3207, 493, true);
            WriteLiteral(@"                  
                </tbody>
        </table>

    </main>
</div>
<div class=""container"" style=""min-height: 45em"">
    <main role=""main"" class=""pb-1"">
        <div class=""row"">
            <div class=""col-6"">
                <div class=""table-responsive"">
                    <table class=""table table-striped"">
                        <tbody>
                            <tr>
                                <td style=""font-size: 18px; font-weight:bold;"">備註：<br> ");
            EndContext();
            BeginContext(3701, 38, false);
#line 105 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(3739, 223, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"font-size: 18px; font-weight:bold; text-align:left;\">\r\n                                    租借剩餘期限：<br>\r\n");
            EndContext();
#line 110 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                     if (Model.Restore_time.Subtract(DateTime.Now).TotalDays > 0) {
                                        

#line default
#line hidden
            BeginContext(4104, 81, false);
#line 111 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                   Write(Html.Raw(Model.Restore_time.Subtract(DateTime.Now).TotalDays.ToString("0") + "天"));

#line default
#line hidden
            EndContext();
#line 111 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                                                                          ;
                                    } else if (Model.Restore_state) {
                                        

#line default
#line hidden
            BeginContext(4300, 45, false);
#line 113 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                   Write(Html.Raw("<a style=\"color:purple\">已歸還</a>"));

#line default
#line hidden
            EndContext();
#line 113 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                                      
                                    } else {
                                        

#line default
#line hidden
            BeginContext(4434, 49, false);
#line 115 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                   Write(Html.Raw("<a style=\"color:red\">已逾期! 請盡速歸還</a>"));

#line default
#line hidden
            EndContext();
#line 115 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                                          
                                    }

#line default
#line hidden
            BeginContext(4524, 488, true);
            WriteLiteral(@"
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""col-6"">
                <div class=""table-responsive"">
                    <table class=""table table-striped"">
                        <tbody>
                            <tr>
                                <td style=""font-size: 18px; font-weight:bold; text-align:left;"">總額：");
            EndContext();
            BeginContext(5013, 20, false);
#line 129 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                                              Write(Html.Raw(totalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(5033, 177, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"font-size: 18px; font-weight:bold; text-align:left;\">訂單時間：");
            EndContext();
            BeginContext(5211, 43, false);
#line 132 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.Borrow_time));

#line default
#line hidden
            EndContext();
            BeginContext(5254, 177, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"font-size: 18px; font-weight:bold; text-align:left;\">訂單期限：");
            EndContext();
            BeginContext(5432, 66, false);
#line 135 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                                                                                                Write(Html.Raw(Model.Restore_time.Subtract(Model.Borrow_time).TotalDays));

#line default
#line hidden
            EndContext();
            BeginContext(5498, 201, true);
            WriteLiteral("天</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5699, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf25ba83025ba5a6535e82af2e28a2a65a6ac55422234", async() => {
                BeginContext(5745, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 146 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\BorrowOrders\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(5753, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(5761, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf25ba83025ba5a6535e82af2e28a2a65a6ac55424578", async() => {
                BeginContext(5783, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5799, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EquipmentManagement.Models.BorrowOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
