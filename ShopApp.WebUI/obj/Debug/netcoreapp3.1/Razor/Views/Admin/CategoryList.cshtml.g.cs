#pragma checksum "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dda0fbaa553924b395981f0e7e7e019d94d46038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
#line 1 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda0fbaa553924b395981f0e7e7e019d94d46038", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca7dd7215f156ae1ed0d79360326521626c385c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletecategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
  
    ViewData["Title"] = "CategoryList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Kategori Düzenle</h1>\r\n<hr />\r\n");
#nullable restore
#line 10 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
 if (Model.Categories.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td style=""width:30px;"">Id</td>
                <td style=""width:100px;"">Kategori Adı</td>
                <td style=""width:150px;""></td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary btn-sm mr-2\"");
            BeginWriteAttribute("href", " href=\"", 698, "\"", 733, 2);
            WriteAttributeValue("", 705, "/admin/editcategory/", 705, 20, true);
#nullable restore
#line 27 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 725, item.Id, 725, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dda0fbaa553924b395981f0e7e7e019d94d460386395", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 917, "\"", 933, 1);
#nullable restore
#line 30 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 925, item.Id, 925, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 41 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <h4>Kategori Yok</h4>\r\n    </div>\r\n");
#nullable restore
#line 47 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Admin\CategoryList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591