#pragma checksum "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e283cc7eac0d267da8ca713b6457a63fd64b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\_ViewImports.cshtml"
using HBR.Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\_ViewImports.cshtml"
using HBR.Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e283cc7eac0d267da8ca713b6457a63fd64b61", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c95a7e8a6d5a92b7201cb4e05abbd581960d064", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HBR.Persistence.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-datetimepicker/moment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-datetimepicker/bootstrap-datetimepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section>\r\n\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Product\Create.cshtml"
         using (Html.BeginForm("Create", "Product", FormMethod.Post, new { onkeydown = "return event.keyCode!=13" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Product\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row clearfix"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <div class=""card"">
                        <div class=""body"">
                            <div class=""row clearfix"">

                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Producto</label>
                                        <input type=""text"" name=""_Name"" id=""name"" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Precio</label>
                                        <input type=""text"" name=""Price"" id=""price"" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>
      ");
            WriteLiteral(@"                          <div class=""col-sm-4"">
                                    <label>Expiración</label>
                                    <div class=""input-group"">
                                        <span class=""input-group-addon"">
                                            <i class=""zmdi zmdi-calendar""></i>
                                        </span>
                                        <input type=""text"" id=""datetimepicker2"" name=""Expiration"" class=""datetimepicker form-control"" data-dtp=""dtp_BHWlZ"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row clearfix"">

                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Proveedor</label>
                                        <input type=""text"" name=""_Provider"" id=""provider"" class=""form-control"" placeholder="" """);
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Direcciòn</label>
                                        <input type=""text"" name=""Direction"" id=""direction"" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <label class=""form-label"" for=""dllcategories"">Categoria del producto:</label>
                                    <select id=""dllcategories"" style=""text-align:left"" name=""idCategoriesid_Categories"" data-live-search=""true"" class=""form-control"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e283cc7eac0d267da8ca713b6457a63fd64b618728", async() => {
                WriteLiteral("Seleccione");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row clearfix"">
                <div class=""col-md-12"">

                    <div class=""row clearfix"">
                        <div class=""col-sm-1"">
                            <button type=""submit"" id=""register"" class=""btn btn-primary btn-round"">Registrar</button>
                        </div>
                        <div class=""col-sm-2"">
                            <button type=""button"" class=""btn btn-default btn-round btn-simple"" id=""btn_cancelar"">Cancelar</button>
                        </div>

                    </div>
                </div>
            </div>
");
#nullable restore
#line 83 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Product\Create.cshtml"




        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e283cc7eac0d267da8ca713b6457a63fd64b6111057", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e283cc7eac0d267da8ca713b6457a63fd64b6112097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e283cc7eac0d267da8ca713b6457a63fd64b6113149", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e283cc7eac0d267da8ca713b6457a63fd64b6114189", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    $(document).ready(function () {\r\n\r\n        $(\'#btn_cancelar\').click(function () {\r\n            window.location.href = \'/Product/Index\';\r\n        })\r\n\r\n        debugger\r\n      $.getJSON(\"");
#nullable restore
#line 109 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Product\Create.cshtml"
            Write(Url.Action("GetCategories", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", null, function (data) {

            var ProductsCat = JSON.parse(data);
            ProductsCat.forEach(AppendProductCat);

        }).then(() => {
            $('#dllcategories').selectpicker('refresh');
        });
        function AppendProductCat(item, index) {
            $(""#dllcategories"").append('<option value=""' + item.Value + '"">' + item.Text +'</option>');

        }


        //Datetimepicker plugin
        $('.datetimepicker').bootstrapMaterialDatePicker({
            lang: 'es',
            locale: 'es',
            clearButton: true,
            time: false,
            weekStart: 1
        });

        $('.datetimepicker2').bootstrapMaterialDatePicker({
            lang: 'es',
            format: 'YYYY-MM-DD HH:mm',
            clearButton: true,
            weekStart: 1
        });

    });

    $(function () {

        var name, price, datetimepicker2, provider, direction, dllcategories;
        $(""#register"").on('click', function () {
            name");
            WriteLiteral(@" = $(""#name"").val();
            price = $(""#price"").val();
            datetimepicker2 = $(""#datetimepicker2"").val();
            provider = $(""#provider"").val();
            direction = $(""#direction"").val();
            dllcategories = $(""#dllcategories"").val();

            if (name.length == 0 || price.length == 0 || datetimepicker2.length == 0 || provider.length == 0 || direction.length == 0 || dllcategories.length == 0) {
                alert(""Existen campos vacios"");
                return false;
            }
            return true;
        });
    });


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HBR.Persistence.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
