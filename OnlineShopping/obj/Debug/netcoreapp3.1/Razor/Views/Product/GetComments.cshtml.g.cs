#pragma checksum "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Product\GetComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a39eb1e6a8edb6c1ec9aba62839ab92fa20616f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetComments), @"mvc.1.0.view", @"/Views/Product/GetComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a39eb1e6a8edb6c1ec9aba62839ab92fa20616f", @"/Views/Product/GetComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927d08e84458342e0535e4e5b57d85e5143a4556", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Product\GetComments.cshtml"
 foreach (var item in Model.comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"m-2 p-2\" style=\"border-bottom:solid 1px\">\r\n\r\n        <p style=\"color:forestgreen\" >");
#nullable restore
#line 9 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Product\GetComments.cshtml"
                                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"color:black;font-weight: 500;\">");
#nullable restore
#line 10 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Product\GetComments.cshtml"
                                            Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        by: <p style=\"display:inline\">");
#nullable restore
#line 11 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Product\GetComments.cshtml"
                                 Write(item.Member.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n");
#nullable restore
#line 14 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Views\Product\GetComments.cshtml"
  

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
