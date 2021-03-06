#pragma checksum "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ef3d106bd975e7b98215e8071b5904b29c9161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetOrders), @"mvc.1.0.view", @"/Views/Cart/GetOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ef3d106bd975e7b98215e8071b5904b29c9161", @"/Views/Cart/GetOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca7dd7215f156ae1ed0d79360326521626c385c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
  
    ViewData["Title"] = "GetOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sipari??lerim</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 9 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-sm mb-3\">\r\n        <thead class=\"bg-primary text-white\">\r\n            <tr>\r\n                <td colspan=\"2\">Sipari?? Id: #");
#nullable restore
#line 14 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                        Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>Fiyat</th>\r\n                <th>Adet</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
             foreach (var orderItem in order.OrderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\" style=\"width:60px;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23ef3d106bd975e7b98215e8071b5904b29c91614828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 634, "~/img/", 634, 6, true);
#nullable restore
#line 24 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
AddHtmlAttributeValue("", 640, orderItem.ImageUrl, 640, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 27 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 30 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"2\">M????teri Ad??:</td>\r\n                <td>");
#nullable restore
#line 38 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td rowspan=\"3\">Total ");
#nullable restore
#line 39 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                 Write(order.TotalPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Adres:</td>\r\n                <td>");
#nullable restore
#line 43 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Telefon:</td>\r\n                <td>");
#nullable restore
#line 47 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">??deme Tipi:</td>\r\n                <td>");
#nullable restore
#line 51 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.PaymentTypes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Sipari?? Durumu:</td>\r\n                <td>");
#nullable restore
#line 55 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">E-mail:</td>\r\n                <td>");
#nullable restore
#line 59 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 63 "D:\E diski yedek\REPOS\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
