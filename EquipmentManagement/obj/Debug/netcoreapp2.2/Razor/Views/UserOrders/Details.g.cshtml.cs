#pragma checksum "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b00f04a9c0ba2e991d7384e9df58b5a5269f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserOrders_Details), @"mvc.1.0.view", @"/Views/UserOrders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserOrders/Details.cshtml", typeof(AspNetCore.Views_UserOrders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b00f04a9c0ba2e991d7384e9df58b5a5269f4a", @"/Views/UserOrders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eafb0ab7b065fb2e3bbc3e4c414fbe958707142e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserOrders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EquipmentManagement.Models.BorrowOrder>
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
#line 3 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
  
    ViewData["Title"] = "訂單明細";
    int totalPrice = 0;

#line default
#line hidden
            BeginContext(114, 154, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"min-height: 22em\">\r\n    <main role=\"main\" class=\"pb-1\">\r\n        <h1>我的訂單明細</h1>\r\n        <p>\r\n            <a href=\"#\">編號-");
            EndContext();
            BeginContext(269, 74, false);
#line 12 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                      Write(Html.Raw(string.Format("{0:yyyyMMdd}{1:00}", Model.Borrow_time, Model.Id)));

#line default
#line hidden
            EndContext();
            BeginContext(343, 62, true);
            WriteLiteral("</a>\r\n        </p>\r\n        <hr />\r\n        <dl class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
             if (Model.Member.Name != "") {

#line default
#line hidden
            BeginContext(450, 59, true);
            WriteLiteral("                <dt class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(510, 47, false);
#line 18 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Member.Name));

#line default
#line hidden
            EndContext();
            BeginContext(557, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
            EndContext();
            BeginContext(642, 43, false);
#line 21 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
               Write(Html.DisplayFor(model => model.Member.Name));

#line default
#line hidden
            EndContext();
            BeginContext(685, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 23 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(725, 51, true);
            WriteLiteral("            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(777, 44, false);
#line 25 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(821, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
            EndContext();
            BeginContext(894, 40, false);
#line 28 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
           Write(Html.DisplayFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(934, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 30 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
             if (Model.Member.Hot_mail != Model.Stu_mail && Model.Member.Hot_mail != "") {

#line default
#line hidden
            BeginContext(1047, 59, true);
            WriteLiteral("                <dt class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(1107, 51, false);
#line 32 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Member.Hot_mail));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
            EndContext();
            BeginContext(1243, 47, false);
#line 35 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
               Write(Html.DisplayFor(model => model.Member.Hot_mail));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 37 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1330, 53, true);
            WriteLiteral("\r\n            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1384, 48, false);
#line 40 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Restore_time));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
            EndContext();
            BeginContext(1505, 44, false);
#line 43 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
           Write(Html.DisplayFor(model => model.Restore_time));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1622, 49, false);
#line 46 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Restore_state));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
            EndContext();
            BeginContext(1744, 45, false);
#line 49 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
           Write(Html.DisplayFor(model => model.Restore_state));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 378, true);
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
#line 66 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                 foreach (var item in Model.BorrowRecords) {
                    totalPrice += item.Price;

#line default
#line hidden
            BeginContext(2276, 71, true);
            WriteLiteral("                    <tr>\r\n                        <td align=\"center\">\r\n");
            EndContext();
#line 70 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                         if(item.Equipment.Img != null) {

#line default
#line hidden
            BeginContext(2388, 93, true);
            WriteLiteral("                            <div class=\"img-thumbnail\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2481, "\"", 2555, 3);
            WriteAttributeValue("", 2487, "data:image/png;base64,", 2487, 22, true);
#line 72 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
WriteAttributeValue("", 2509, Convert.ToBase64String(item.Equipment.Img), 2509, 45, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2554, "", 2555, 1, true);
            EndWriteAttribute();
            BeginContext(2556, 54, true);
            WriteLiteral(" width=\"40\">\r\n                                </div>\r\n");
            EndContext();
#line 74 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
								}

#line default
#line hidden
            BeginContext(2621, 59, true);
            WriteLiteral("                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(2681, 29, false);
#line 76 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                       Write(Html.Raw(item.Equipment.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2710, 39, true);
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n");
            EndContext();
#line 79 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                             if (Model.Member.Member_fee) {
                                

#line default
#line hidden
            BeginContext(2843, 37, false);
#line 80 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                           Write(Html.Raw(item.Equipment.Price_member));

#line default
#line hidden
            EndContext();
#line 80 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                      ;
                            } else {
                                

#line default
#line hidden
            BeginContext(2954, 41, false);
#line 82 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                           Write(Html.Raw(item.Equipment.Price_non_member));

#line default
#line hidden
            EndContext();
#line 82 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                          ;
                            }

#line default
#line hidden
            BeginContext(3029, 59, true);
            WriteLiteral("                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(3089, 23, false);
#line 85 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                       Write(Html.Raw(item.Quantuty));

#line default
#line hidden
            EndContext();
            BeginContext(3112, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3148, 20, false);
#line 86 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                       Write(Html.Raw(item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3204, 21, false);
#line 87 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                       Write(Html.Raw(item.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(3225, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 89 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3278, 483, true);
            WriteLiteral(@"
            </tbody>
        </table>
    </main>
</div>

<br>
<hr>
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
            BeginContext(3762, 38, false);
#line 106 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
            EndContext();
            BeginContext(3800, 223, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"font-size: 18px; font-weight:bold; text-align:left;\">\r\n                                    租借剩餘期限：<br>\r\n");
            EndContext();
#line 111 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                     if (Model.Restore_time.Subtract(DateTime.Now).TotalDays > 0) {
                                        

#line default
#line hidden
            BeginContext(4165, 81, false);
#line 112 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                   Write(Html.Raw(Model.Restore_time.Subtract(DateTime.Now).TotalDays.ToString("0") + "天"));

#line default
#line hidden
            EndContext();
#line 112 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                                                                          ;
                                    } else if (Model.Restore_state) {
                                        

#line default
#line hidden
            BeginContext(4361, 45, false);
#line 114 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                   Write(Html.Raw("<a style=\"color:purple\">已歸還</a>"));

#line default
#line hidden
            EndContext();
#line 114 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                                      
                                    } else {
                                        

#line default
#line hidden
            BeginContext(4495, 49, false);
#line 116 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                   Write(Html.Raw("<a style=\"color:red\">已逾期! 請盡速歸還</a>"));

#line default
#line hidden
            EndContext();
#line 116 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                                          
                                    }

#line default
#line hidden
            BeginContext(4585, 488, true);
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
            BeginContext(5074, 20, false);
#line 130 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                                              Write(Html.Raw(totalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(5094, 177, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"font-size: 18px; font-weight:bold; text-align:left;\">訂單時間：");
            EndContext();
            BeginContext(5272, 43, false);
#line 133 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.Borrow_time));

#line default
#line hidden
            EndContext();
            BeginContext(5315, 177, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"font-size: 18px; font-weight:bold; text-align:left;\">訂單期限：");
            EndContext();
            BeginContext(5493, 66, false);
#line 136 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
                                                                                                Write(Html.Raw(Model.Restore_time.Subtract(Model.Borrow_time).TotalDays));

#line default
#line hidden
            EndContext();
            BeginContext(5559, 201, true);
            WriteLiteral("天</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5760, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36b00f04a9c0ba2e991d7384e9df58b5a5269f4a22232", async() => {
                BeginContext(5806, 4, true);
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
#line 147 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\UserOrders\Details.cshtml"
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
            BeginContext(5814, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(5822, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36b00f04a9c0ba2e991d7384e9df58b5a5269f4a24574", async() => {
                BeginContext(5844, 12, true);
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
            BeginContext(5860, 12, true);
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
