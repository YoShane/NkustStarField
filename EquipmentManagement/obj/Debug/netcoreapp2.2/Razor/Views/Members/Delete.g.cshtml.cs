#pragma checksum "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d886a813c42fbb710224483307f49911f38c428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Delete), @"mvc.1.0.view", @"/Views/Members/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Members/Delete.cshtml", typeof(AspNetCore.Views_Members_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d886a813c42fbb710224483307f49911f38c428", @"/Views/Members/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2251c7943319063494df12f7cbe907de7125c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EquipmentManagement.Models.Member>
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
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 233, true);
            WriteLiteral("\n            <h1>刪除確認</h1>\n\n            <h3>您確定要刪除此使用者?</h3>\n            <div>\n                <h4>Member</h4>\n                <hr />\n                <dl class=\"row\">\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(315, 44, false);
#line 15 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(359, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(454, 40, false);
#line 18 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(494, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(588, 41, false);
#line 21 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(629, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(724, 37, false);
#line 24 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(761, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(855, 40, false);
#line 27 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(895, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(990, 36, false);
#line 30 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1120, 44, false);
#line 33 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Identity));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1259, 40, false);
#line 36 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Identity));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1393, 46, false);
#line 39 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Member_fee));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1534, 42, false);
#line 42 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Member_fee));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1670, 46, false);
#line 45 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1811, 42, false);
#line 48 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 66, true);
            WriteLiteral("\n                    </dd>\n                </dl>\n\n                ");
            EndContext();
            BeginContext(1919, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d886a813c42fbb710224483307f49911f38c42810815", async() => {
                BeginContext(1945, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(1966, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d886a813c42fbb710224483307f49911f38c42811218", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Delete.cshtml"
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
                BeginContext(2002, 105, true);
                WriteLiteral("\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n                    ");
                EndContext();
                BeginContext(2107, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d886a813c42fbb710224483307f49911f38c42813160", async() => {
                    BeginContext(2129, 5, true);
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
                BeginContext(2138, 17, true);
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
            BeginContext(2162, 19, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EquipmentManagement.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
