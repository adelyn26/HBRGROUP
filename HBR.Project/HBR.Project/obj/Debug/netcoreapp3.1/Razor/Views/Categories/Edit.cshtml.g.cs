#pragma checksum "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Categories\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fafdb0ab8a33a8bf30d035d7142147855ddabc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Edit), @"mvc.1.0.view", @"/Views/Categories/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fafdb0ab8a33a8bf30d035d7142147855ddabc8", @"/Views/Categories/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c95a7e8a6d5a92b7201cb4e05abbd581960d064", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HBR.Persistence.Models.Categories>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Menu/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Menu/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<section>\r\n\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Categories\Edit.cshtml"
         using (Html.BeginForm("Edit", "Categories", FormMethod.Post, new { onkeydown = "return event.keyCode!=13" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Categories\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\" name=\"id_Categories\"");
            BeginWriteAttribute("value", " value=\"", 318, "\"", 346, 1);
#nullable restore
#line 11 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Categories\Edit.cshtml"
WriteAttributeValue("", 326, Model.id_Categories, 326, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div class=""row clearfix"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <div class=""card"">
                        <div class=""body"">
                            <div class=""row clearfix"">

                                <div class=""col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Nombre de la categoria</label>
                                        <input type=""text"" name=""_Name"" id=""name""");
            BeginWriteAttribute("value", " value=\"", 873, "\"", 893, 1);
#nullable restore
#line 21 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Categories\Edit.cshtml"
WriteAttributeValue("", 881, Model._Name, 881, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""row clearfix"">


                        <div class=""col-sm-12"">
                            <button type=""submit"" id=""register"" class=""btn btn-primary btn-round"">Editar</button>
                            <button type=""button"" class=""btn btn-default btn-round btn-simple"" id=""btn_cancelar"">Cancelar</button>
                        </div>
                    </div>
                </div>

            </div>
");
#nullable restore
#line 39 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Categories\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fafdb0ab8a33a8bf30d035d7142147855ddabc86765", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fafdb0ab8a33a8bf30d035d7142147855ddabc87804", async() => {
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
            WriteLiteral(@"

<script type=""text/javascript"">

    $(document).ready(function () {

        $('#btn_cancelar').click(function () {
            window.location.href = '/Categories/Index';
        })
    })
    $(function () {

        var name
        $(""#register"").on('click', function () {
            name = $(""#name"").val();

            if (name.length == 0) {
                alert(""El campo esta vacio."");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HBR.Persistence.Models.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
