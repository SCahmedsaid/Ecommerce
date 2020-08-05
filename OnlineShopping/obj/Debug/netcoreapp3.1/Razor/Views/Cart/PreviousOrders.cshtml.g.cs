#pragma checksum "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be1ab2f602c926366de018c6ff580ecaf824497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_PreviousOrders), @"mvc.1.0.view", @"/Views/Cart/PreviousOrders.cshtml")]
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
#line 1 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\_ViewImports.cshtml"
using OnlineShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\_ViewImports.cshtml"
using OnlineShopping.Persistence.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be1ab2f602c926366de018c6ff580ecaf824497", @"/Views/Cart/PreviousOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927d08e84458342e0535e4e5b57d85e5143a4556", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_PreviousOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger m-auto w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
  
    ViewData["Title"] = "PreviousOrders";
    Layout = "~/Views/shared/_subLayout.cshtml";
    var orders = ViewBag.orders as List<OnlineShopping.Core.DbEntities.Order>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb_section bg_gray page-title-mini"">
    <div class=""container"">
        <!-- STRART CONTAINER -->
        <div class=""row align-items-center"">
            <div class=""col-md-6"">
                <div class=""page-title"">
                    <h1>Previous Orders</h1>
                </div>
            </div>
        </div>
    </div><!-- END CONTAINER-->
</div>

<div class=""main_content"">

    <!-- START SECTION SHOP -->
    <div class=""section"">

");
#nullable restore
#line 27 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
         if (orders.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""table-responsive shop_cart_table"">
                            <table class=""table myTable"">
                                <thead>
                                    <tr>
                                        <th>Product Name</th>
                                        <th class=""product-price"">Date</th>
                                        <th>Shipping State</th>
                                        <th>Address</th>
                                        <th>Phone</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 44 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                     foreach (var item in orders)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"product-name text-center\" data-title=\"Product\">\r\n");
#nullable restore
#line 48 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                             for (int i = 0; i < item.OrderProductDetails.ToList().Count(); i++)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                           Write(item.OrderProductDetails.ToList()[i].Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <br /><br />\r\n");
#nullable restore
#line 52 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n\r\n                                        <td class=\"price\" data-title=\"Price\">");
#nullable restore
#line 55 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                                                        Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td data-title=\"Total\">");
#nullable restore
#line 57 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                                          Write(item.ShippingState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                       Write(item.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 68 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <h2 class=\"m-auto\">No Orders Yet</h2>\r\n                </div><br />\r\n                <div class=\"row\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3be1ab2f602c926366de018c6ff580ecaf8244979926", async() => {
                WriteLiteral("Continue Shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 81 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    </div>\r\n");
            DefineSection("Search", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 85 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
       Write(Html.Partial("_Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
            }
            );
            DefineSection("Category", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 89 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Cart\PreviousOrders.cshtml"
       Write(Html.Partial("_Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
