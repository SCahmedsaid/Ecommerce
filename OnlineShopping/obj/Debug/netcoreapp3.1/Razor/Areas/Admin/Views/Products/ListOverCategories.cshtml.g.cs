#pragma checksum "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a25384cdbb7299f5cee051e836d2c63a8c4b55d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_ListOverCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/ListOverCategories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25384cdbb7299f5cee051e836d2c63a8c4b55d1", @"/Areas/Admin/Views/Products/ListOverCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ed35f2f136be976cdef2b9c40eefaaedf8b07e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_ListOverCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #FFF !important; top: unset !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootbox.js/bootbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
  
    ViewData["Title"] = "Category Products";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- BEGIN: Content-->
<div class=""app-content content"">
    <div class=""content-overlay""></div>
    <div class=""content-wrapper"">
        <div class=""content-header row"">
            <div class=""content-header-left col-12 mb-2 mt-1"">
                <div class=""row breadcrumbs-top"">
                    <div class=""col-12"">
                        <h5 class=""content-header-title float-left pr-1 mb-0"">Where are you : </h5>
                        <div class=""breadcrumb-wrapper col-12"">
                            <ol class=""breadcrumb p-0 mb-0"">
                                <li class=""breadcrumb-item"">
                                    <a><i class=""bx bx-home-alt""></i></a>
                                </li>
                                <li class=""breadcrumb-item"">
                                    <a>Categories</a>
                                </li>
                                <li class=""breadcrumb-item active"">
                                    Products List
      ");
            WriteLiteral(@"                          </li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-body"">
            <!-- Description -->
            <section id=""description"" class=""card"">
                <div class=""card-header"">
                    <h3 class=""card-title"">

                        ");
#nullable restore
#line 39 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" : Products List
                    </h3>
                </div>
                <div class=""card-content"">
                    <div class=""card-body"">
                        <table class=""table table-striped"" id=""tbl"">
                            <thead>
                                <tr>
                                    <th>Product Name</th>
                                    <th>Product Price</th>
                                    <th>Operations</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 53 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                 if (!Model.Products.Any())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td colspan=""3"">
                                            <h2 class=""text-danger text-center"">There is no Products yet.</h2>
                                        </td>
                                    </tr>
");
#nullable restore
#line 60 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                 foreach (var product in Model.Products.Where(x => !x.IsDeleted))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 64 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                       Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 65 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                       Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25384cdbb7299f5cee051e836d2c63a8c4b55d110495", async() => {
                WriteLiteral("\r\n                                                <i style=\"color: #FFF !important; top: unset !important\" class=\"fa fa-trash-o\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25384cdbb7299f5cee051e836d2c63a8c4b55d113288", async() => {
                WriteLiteral("\r\n                                                <i style=\"color: #FFF !important; top: unset !important\" class=\"fa fa-edit\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <a class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3945, "\"", 3986, 3);
            WriteAttributeValue("", 3955, "GetProductComments(", 3955, 19, true);
#nullable restore
#line 78 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
WriteAttributeValue("", 3974, product.Id, 3974, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3985, ")", 3985, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: #FFF !important; top: unset !important""
                                               href=""#"">
                                                <i style=""color: #FFF !important; top: unset !important"" class=""fa fa-address-card""></i>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 84 "F:\01-myfiles\iti\Source code\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\ListOverCategories.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n            <!--/ Description -->\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- END: Content-->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js\" type=\"text/javascript\"></script>\r\n\r\n    <script src=\"https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js\" type=\"text/javascript\"></script>\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25384cdbb7299f5cee051e836d2c63a8c4b55d117944", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        $('#tbl').DataTable({
            //paging: false,

        });

        $('.deleteForm').click(function (e) {
            let event = e;
            e.preventDefault();
            bootbox.confirm({
                message: ""Are you sure you want to delete ?"",
                buttons: {
                    confirm: {
                        label: 'Yes',
                        className: 'btn-success'
                    },
                    cancel: {
                        label: 'No',
                        className: 'btn-danger'
                    }
                },
                callback: function (result) {
                    if (result) {
                        if (e.target.href) {
                            window.location.href = e.target.href;
                        } else {
                            window.location.href = e.target.parentElement.href;
                        }
                    }
                }
            }");
                WriteLiteral(@");

        });
        function GetProductComments(productId) {
            fetch('/Admin/Comments/List/' + productId)
                .then(response => {
                    return response.text();
                }).then(response => {
                    // Initialize the DOM parser
                    var parser = new DOMParser();
                    // Parse the text
                    var doc = parser.parseFromString(response, ""text/html"");
                    console.log(doc);
                    document.querySelector('#CommentsDetailsDiv').innerHTML = doc.querySelector('#content').innerHTML;
                    $('#CommentsDetails').modal('show');
                });
        }
    </script>
");
            }
            );
            WriteLiteral(@"


<!-- Modal -->
<div class=""modal fade"" id=""CommentsDetails"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Comments Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""CommentsDetailsDiv""></div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
