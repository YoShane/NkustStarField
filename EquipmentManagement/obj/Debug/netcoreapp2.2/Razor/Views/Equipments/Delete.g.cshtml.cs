#pragma checksum "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fdc1a60ba9d105a2c47ec3d4083ff75019ccd2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipments_Delete), @"mvc.1.0.view", @"/Views/Equipments/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Equipments/Delete.cshtml", typeof(AspNetCore.Views_Equipments_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdc1a60ba9d105a2c47ec3d4083ff75019ccd2c", @"/Views/Equipments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2251c7943319063494df12f7cbe907de7125c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EquipmentManagement.Models.Equipment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
  
    ViewData["Title"] = "器材項目移除";

#line default
#line hidden
            BeginContext(84, 238, true);
            WriteLiteral("\n            <h1>刪除器材項目</h1>\n\n            <h3>將會刪除整個器材項目?</h3>\n            <div>\n                <h4>Equipment</h4>\n                <hr />\n                <dl class=\"row\">\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(323, 39, false);
#line 15 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Img));

#line default
#line hidden
            EndContext();
            BeginContext(362, 70, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n");
            EndContext();
#line 18 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                         if (Model.Img != null) {

#line default
#line hidden
            BeginContext(482, 32, true);
            WriteLiteral("                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 514, "\"", 579, 3);
            WriteAttributeValue("", 520, "data:image/png;base64,", 520, 22, true);
#line 19 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
WriteAttributeValue("", 542, Convert.ToBase64String(Model.Img), 542, 36, false);

#line default
#line hidden
            WriteAttributeValue(" ", 578, "", 579, 1, true);
            EndWriteAttribute();
            BeginContext(580, 16, true);
            WriteLiteral(" width=\"150\" />\n");
            EndContext();
#line 20 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                        }

#line default
#line hidden
            BeginContext(622, 92, true);
            WriteLiteral("                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(715, 40, false);
#line 23 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(755, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(850, 36, false);
#line 26 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(886, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(980, 44, false);
#line 29 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1119, 40, false);
#line 32 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1253, 52, false);
#line 35 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price_non_member));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1400, 48, false);
#line 38 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Price_non_member));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1542, 48, false);
#line 41 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price_member));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1685, 44, false);
#line 44 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Price_member));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1823, 42, false);
#line 47 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1960, 38, false);
#line 50 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Source));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(2092, 43, false);
#line 53 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Special));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(2230, 39, false);
#line 56 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Special));

#line default
#line hidden
            EndContext();
            BeginContext(2269, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(2363, 47, false);
#line 59 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Period_time));

#line default
#line hidden
            EndContext();
            BeginContext(2410, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(2505, 43, false);
#line 62 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Period_time));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(2642, 49, false);
#line 65 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Location_code));

#line default
#line hidden
            EndContext();
            BeginContext(2691, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(2786, 45, false);
#line 68 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Location_code));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 66, true);
            WriteLiteral("\n                    </dd>\n                </dl>\n\n                ");
            EndContext();
            BeginContext(2897, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fdc1a60ba9d105a2c47ec3d4083ff75019ccd2c14584", async() => {
                BeginContext(2923, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(2944, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fdc1a60ba9d105a2c47ec3d4083ff75019ccd2c14987", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 73 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Equipments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2980, 105, true);
                WriteLiteral("\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n                    ");
                EndContext();
                BeginContext(3085, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fdc1a60ba9d105a2c47ec3d4083ff75019ccd2c16932", async() => {
                    BeginContext(3107, 5, true);
                    WriteLiteral("回到上一頁");
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
                BeginContext(3116, 17, true);
                WriteLiteral("\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3140, 19, true);
            WriteLiteral("\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EquipmentManagement.Models.Equipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
