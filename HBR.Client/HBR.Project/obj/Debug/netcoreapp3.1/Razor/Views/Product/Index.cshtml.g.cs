#pragma checksum "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f3d3fd8d087333284fac22be395b41a7c04f10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\_ViewImports.cshtml"
using HBR.Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\_ViewImports.cshtml"
using HBR.Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f3d3fd8d087333284fac22be395b41a7c04f10", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c95a7e8a6d5a92b7201cb4e05abbd581960d064", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HBR.Persistence.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n");
#nullable restore
#line 20 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
         using (Html.BeginForm("Index", "Product", FormMethod.Post, new { onkeydown = "return event.keyCode!=13" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row clearfix"">
                <div class=""col-md-12"">
                    <div class=""card patients-list"">
                        <div class=""body"">
                            <div class=""tab-content m-t-12"">
                                <div class=""tab-pane table-responsive active"" id=""All"">
                                    <table id=""example"" class=""table table-striped table-bordered"" style=""width:100%; align-content:center"">
                                        <thead>
                                            <tr class=""col-sm-12"">
                                                <th>Productos</th>
                                                <th>Precio</th>
                                                <th>Expiraciòn</th>
                                                <th>Proveedor</th>
                                                <th>Direcciòn</th>
                                            </tr>
                                        </thea");
            WriteLiteral("d>\r\n                                        <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 44 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item._Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 47 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 50 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Expiration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 53 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item._Provider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 56 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Direction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 69 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70f3d3fd8d087333284fac22be395b41a7c04f109185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70f3d3fd8d087333284fac22be395b41a7c04f1010224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        $(\'#example\').DataTable();\r\n\r\n\r\n\r\n    });\r\n\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HBR.Persistence.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591