#pragma checksum "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149af0e14842dc95d3bca80d965af1500c8b489f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipments_Index), @"mvc.1.0.view", @"/Views/Equipments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Equipments/Index.cshtml", typeof(AspNetCore.Views_Equipments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149af0e14842dc95d3bca80d965af1500c8b489f", @"/Views/Equipments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eafb0ab7b065fb2e3bbc3e4c414fbe958707142e", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EquipmentManagement.Models.Equipment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Locations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
  
    ViewData["Title"] = "器材總覽";

#line default
#line hidden
            BeginContext(98, 136, true);
            WriteLiteral("<div class=\"container\" style=\"min-height: 45em\">\r\n    <main role=\"main\" class=\"pb-1\">\r\n        <h1>登山社器材</h1>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(234, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149af0e14842dc95d3bca80d965af1500c8b489f5144", async() => {
                BeginContext(257, 4, true);
                WriteLiteral("新增器材");
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
            BeginContext(265, 21, true);
            WriteLiteral(" | \r\n                ");
            EndContext();
            BeginContext(286, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149af0e14842dc95d3bca80d965af1500c8b489f6531", async() => {
                BeginContext(336, 4, true);
                WriteLiteral("存放設定");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(344, 203, true);
            WriteLiteral("\r\n        </p>\r\n\r\n        <table class=\"myTable\">\r\n            <thead>\r\n                <tr>\r\n\t\t\t\t <th>\r\n\t\t\t\t Id\r\n                    </th>\r\n                    <th colspan=\"2\">\r\n                        ");
            EndContext();
            BeginContext(548, 40, false);
#line 20 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(588, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(668, 43, false);
#line 23 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Surplus));

#line default
#line hidden
            EndContext();
            BeginContext(711, 160, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        已借\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(872, 44, false);
#line 29 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(916, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(996, 52, false);
#line 32 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price_non_member));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1128, 48, false);
#line 35 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price_member));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1256, 49, false);
#line 38 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Location_code));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 167, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n\r\n                <!-- style=\"background-color:rgb(249, 148, 156)\" -->\r\n");
            EndContext();
#line 45 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                 foreach (var item in Model) {
                    var style = "";
                    if (item.Surplus == 0) {
                        style = "color:red";
                    } else if(item.Quantity-item.Surplus>0) {
                        style = "color:green";
                    }

#line default
#line hidden
            BeginContext(1783, 59, true);
            WriteLiteral("                <tr>\r\n\t\t\t\t\t  <td>\r\n                        ");
            EndContext();
            BeginContext(1843, 37, false);
#line 54 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 57 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                         if (item.Img != null) {

#line default
#line hidden
            BeginContext(1985, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2013, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149af0e14842dc95d3bca80d965af1500c8b489f12729", async() => {
                BeginContext(2061, 38, true);
                WriteLiteral("\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2099, "\"", 2163, 3);
                WriteAttributeValue("", 2105, "data:image/png;base64,", 2105, 22, true);
#line 59 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
WriteAttributeValue("", 2127, Convert.ToBase64String(item.Img), 2127, 35, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2162, "", 2163, 1, true);
                EndWriteAttribute();
                BeginContext(2164, 67, true);
                WriteLiteral(" width=\"50\" class=\"img-thumbnail \" />\r\n                            ");
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
#line 58 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
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
            BeginContext(2235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 61 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2264, 77, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2341, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149af0e14842dc95d3bca80d965af1500c8b489f16156", async() => {
                BeginContext(2386, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2388, 39, false);
#line 64 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2427, 2, true);
                WriteLiteral("  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
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
            BeginContext(2433, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2485, "\"", 2499, 1);
#line 66 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
WriteAttributeValue("", 2493, style, 2493, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2500, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(2528, 42, false);
#line 67 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Surplus));

#line default
#line hidden
            EndContext();
            BeginContext(2570, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2650, 56, false);
#line 70 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.Raw(Convert.ToString(item.Quantity - item.Surplus)));

#line default
#line hidden
            EndContext();
            BeginContext(2706, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2788, 43, false);
#line 74 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2911, 51, false);
#line 77 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price_non_member));

#line default
#line hidden
            EndContext();
            BeginContext(2962, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3042, 47, false);
#line 80 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price_member));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3169, 48, false);
#line 83 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Location_code));

#line default
#line hidden
            EndContext();
            BeginContext(3217, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 86 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3288, 59, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EquipmentManagement.Models.Equipment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
