#pragma checksum "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ed091930c2eb81c473e771ce6015bb29ef3a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Edit), @"mvc.1.0.view", @"/Views/Users/Edit.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ed091930c2eb81c473e771ce6015bb29ef3a0e", @"/Views/Users/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c95a7e8a6d5a92b7201cb4e05abbd581960d064", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HBR.Persistence.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.mask.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.mask.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section>

    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-lg-5 col-md-5 col-sm-12"">

            </div>
            <div class=""col-lg-7 col-md-7 col-sm-12 text-right"">


                <ul class=""breadcrumb float-md-right"">
                    <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 446, "\"", 480, 1);
#nullable restore
#line 15 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 453, Url.Action("Index","Home"), 453, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-home\"></i> Inicio</a></li>\r\n                    <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("href", " href=\"", 580, "\"", 607, 1);
#nullable restore
#line 16 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 587, Url.Action("Index"), 587, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-library\"></i> Editar Perfil</a></li>\r\n                    <li class=\"breadcrumb-item active\">Registrar Perfil </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container-fluid\">\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
         using (Html.BeginForm("Edit", "Users", FormMethod.Post, new { onkeydown = "return event.keyCode!=13" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\" name=\"id_User\"");
            BeginWriteAttribute("value", " value=\"", 1067, "\"", 1089, 1);
#nullable restore
#line 28 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 1075, Model.id_User, 1075, 14, false);

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
                                        <label>Nombre</label>
                                        <input type=""text"" name=""_Name""");
            BeginWriteAttribute("value", " value=\"", 1590, "\"", 1610, 1);
#nullable restore
#line 38 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 1598, Model._Name, 1598, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>
                                <div class=""col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Apellido</label>
                                        <input type=""text"" name=""LastName""");
            BeginWriteAttribute("value", " value=\"", 1992, "\"", 2015, 1);
#nullable restore
#line 44 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 2000, Model.LastName, 2000, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>

                            </div>
                            <div class=""row clearfix"">

                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Telefono</label>
                                        <input type=""text"" name=""Telephone"" id=""telephone""");
            BeginWriteAttribute("value", " value=\"", 2509, "\"", 2533, 1);
#nullable restore
#line 54 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 2517, Model.Telephone, 2517, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Correo Electronico</label>
                                        <input type=""text"" name=""Email""");
            BeginWriteAttribute("value", " value=\"", 2922, "\"", 2942, 1);
#nullable restore
#line 60 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 2930, Model.Email, 2930, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder="" "">
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Contraseña</label>
                                        <input type=""text"" name=""_Password""");
            BeginWriteAttribute("value", " value=\"", 3327, "\"", 3351, 1);
#nullable restore
#line 66 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 3335, Model._Password, 3335, 16, false);

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

                            <button type=""submit"" id=""edit"" class=""btn btn-primary btn-round"">Editar</button>
                            <a");
            BeginWriteAttribute("href", " href=\"", 3816, "\"", 3855, 2);
            WriteAttributeValue("", 3823, "\\Users\\Profile?id=", 3823, 18, true);
#nullable restore
#line 78 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
WriteAttributeValue("", 3841, Model.id_User, 3841, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Regresar\" type=\"button\" class=\"btn btn-outline-primary\">Regresar</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 84 "C:\Users\Adelyn\source\repos\HBR.Client\HBR.Project\Views\Users\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ed091930c2eb81c473e771ce6015bb29ef3a0e12518", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ed091930c2eb81c473e771ce6015bb29ef3a0e13558", async() => {
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ed091930c2eb81c473e771ce6015bb29ef3a0e14602", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89ed091930c2eb81c473e771ce6015bb29ef3a0e15642", async() => {
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
            WriteLiteral(@"

<script type=""text/javascript"">

    $(document).ready(function () {
        $('#telephone').mask('(000)000-0000');

        $('#btn_cancelar').click(function () {
            window.location.href = '/Users/Profile';

        $('#edit').click(function () {
            window.location.href = '/Users/Profile';
        })


    });

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor httpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HBR.Persistence.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591