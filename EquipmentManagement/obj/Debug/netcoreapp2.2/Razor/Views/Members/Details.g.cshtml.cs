#pragma checksum "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432afafc2d1e95a46338c5b4a5a6b005e80ab3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Details), @"mvc.1.0.view", @"/Views/Members/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Members/Details.cshtml", typeof(AspNetCore.Views_Members_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432afafc2d1e95a46338c5b4a5a6b005e80ab3bd", @"/Views/Members/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2251c7943319063494df12f7cbe907de7125c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EquipmentManagement.Models.Member>
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
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
  
    ViewData["Title"] = "詳細資訊查詢";

#line default
#line hidden
            BeginContext(81, 200, true);
            WriteLiteral("\n            <h1>個人資料</h1>\n\n            <div>\n                <h4>Member</h4>\n                <hr />\n                <dl class=\"row\">\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(282, 44, false);
#line 14 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(326, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(421, 40, false);
#line 17 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Stu_mail));

#line default
#line hidden
            EndContext();
            BeginContext(461, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(555, 41, false);
#line 20 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(596, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(691, 37, false);
#line 23 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(728, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(822, 40, false);
#line 26 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(862, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(957, 36, false);
#line 29 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(993, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1087, 44, false);
#line 32 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Hot_mail));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1226, 40, false);
#line 35 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Hot_mail));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1360, 44, false);
#line 38 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Identity));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1499, 40, false);
#line 41 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Identity));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1633, 46, false);
#line 44 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Member_fee));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(1774, 42, false);
#line 47 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Member_fee));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 93, true);
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
            EndContext();
            BeginContext(1910, 46, false);
#line 50 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 94, true);
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
            EndContext();
            BeginContext(2051, 42, false);
#line 53 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
                   Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 102, true);
            WriteLiteral("\n                    </dd>\n                </dl>\n            </div>\n            <div>\n                ");
            EndContext();
            BeginContext(2195, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "432afafc2d1e95a46338c5b4a5a6b005e80ab3bd11089", async() => {
                BeginContext(2241, 4, true);
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
#line 58 "C:\Users\shane\Documents\GitHub\NkustStarField\EquipmentManagement\Views\Members\Details.cshtml"
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
            BeginContext(2249, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2268, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "432afafc2d1e95a46338c5b4a5a6b005e80ab3bd13450", async() => {
                BeginContext(2290, 5, true);
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
            BeginContext(2299, 19, true);
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
