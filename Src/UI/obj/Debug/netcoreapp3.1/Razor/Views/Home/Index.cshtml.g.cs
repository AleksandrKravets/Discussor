#pragma checksum "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a5b58f2c8afce2ce09a5e2b7813517a62e092b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\_ViewImports.cshtml"
using Discussor.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\_ViewImports.cshtml"
using Discussor.WebUI.Infrastructure.Pagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a5b58f2c8afce2ce09a5e2b7813517a62e092b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb73938f0887df230a9efa42409ebf94e37aa98", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Discussor.Core.Application.Themes.Queries.GetThemesList.ThemesListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Theme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "37a5b58f2c8afce2ce09a5e2b7813517a62e092b5622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 btn-create-theme text-light\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a5b58f2c8afce2ce09a5e2b7813517a62e092b7048", async() => {
                WriteLiteral("\r\n            Create new theme\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
 if (Model.Themes.Count() == 0 && User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container message-container text-light\">\r\n        <h1>There are no themes. You can leave one ^_^</h1>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
} else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container content text-light\">\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
         foreach (var theme in Model.Themes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row theme\">\r\n                <div class=\"col-2 theme-image-block\">\r\n                    <img class=\"theme-image\"");
            BeginWriteAttribute("src", " src=\"", 836, "\"", 922, 1);
#nullable restore
#line 28 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 842, string.Format("data:image/png;base64,{0}", Convert.ToBase64String(theme.Image)), 842, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col theme-block-content\">\r\n                    <div class=\"col-9\" style=\"padding:7px;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a5b58f2c8afce2ce09a5e2b7813517a62e092b10411", async() => {
#nullable restore
#line 31 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
                                                                                                                                 Write(theme.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-themeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
                                                                                                               WriteLiteral(theme.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["themeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-themeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["themeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                    <div class=\"col-3\" style=\"padding:7px;\">Posts: ");
#nullable restore
#line 32 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
                                                              Write(theme.PostsNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"pager\">\r\n            <cs-pager");
            BeginWriteAttribute("cs-paging-pagenumber", " cs-paging-pagenumber=\"", 1363, "\"", 1436, 4);
            WriteAttributeValue("", 1386, "(", 1386, 1, true);
#nullable restore
#line 38 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1387, ViewData["PagingInfo"], 1387, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1410, "as", 1411, 3, true);
            WriteAttributeValue(" ", 1413, "PagingInfo).PageNumber", 1414, 23, true);
            EndWriteAttribute();
            BeginWriteAttribute("cs-paging-totalitems", "\r\n                      cs-paging-totalitems=\"", 1437, "\"", 1533, 4);
            WriteAttributeValue("", 1483, "(", 1483, 1, true);
#nullable restore
#line 39 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1484, ViewData["PagingInfo"], 1484, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1507, "as", 1508, 3, true);
            WriteAttributeValue(" ", 1510, "PagingInfo).TotalItems", 1511, 23, true);
            EndWriteAttribute();
            BeginWriteAttribute("cs-paging-pagesize", "\r\n                      cs-paging-pagesize=\"", 1534, "\"", 1626, 4);
            WriteAttributeValue("", 1578, "(", 1578, 1, true);
#nullable restore
#line 40 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1579, ViewData["PagingInfo"], 1579, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1602, "as", 1603, 3, true);
            WriteAttributeValue(" ", 1605, "PagingInfo).PageSize", 1606, 21, true);
            EndWriteAttribute();
            WriteLiteral(@"
                      cs-pagenumber-param=""pagenumber""
                      asp-controller=""Home""
                      asp-action=""Index""
                      cs-pager-li-current-class=""page-item active""
                      cs-pager-li-other-class=""page-item""
                      cs-pager-li-non-active-class=""page-item disabled""
                      cs-pager-link-current-class=""page-link""
                      cs-pager-link-other-class=""page-link"">
            </cs-pager>
        </div>
    </div>
");
#nullable restore
#line 52 "C:\Users\Acer\source\repos\Kravets.AspNetCore.Discussor\Src\UI\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Discussor.Core.Application.Themes.Queries.GetThemesList.ThemesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591