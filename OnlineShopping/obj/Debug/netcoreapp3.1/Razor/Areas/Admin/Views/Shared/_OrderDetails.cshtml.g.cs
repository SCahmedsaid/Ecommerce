#pragma checksum "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Shared\_OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9df484c28fe6e16417a9131135465b81560e1a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__OrderDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_OrderDetails.cshtml")]
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
#line 2 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopping.Core.DbEntities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopping.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9df484c28fe6e16417a9131135465b81560e1a1", @"/Areas/Admin/Views/Shared/_OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ed35f2f136be976cdef2b9c40eefaaedf8b07e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderProductDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div id=""content"">
        <table class=""table table-striped"">
            <thead>
            <tr>
                <th scope=""col"">Product</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Quantity</th>
                <th scope=""col"">Total</th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 14 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Shared\_OrderDetails.cshtml"
                 foreach (var i in Model)
                {

                    
                        int sum = i.Price * i.Quantity;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 21 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Shared\_OrderDetails.cshtml"
                       Write(i.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 22 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Shared\_OrderDetails.cshtml"
                       Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Shared\_OrderDetails.cshtml"
                       Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Shared\_OrderDetails.cshtml"
                       Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 26 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Shared\_OrderDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n        \r\n        \r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderProductDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
