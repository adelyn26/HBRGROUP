#pragma checksum "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e50022d0d04dbb9d8becbde3ac51d6070a94c884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Profile), @"mvc.1.0.view", @"/Views/Users/Profile.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50022d0d04dbb9d8becbde3ac51d6070a94c884", @"/Views/Users/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c95a7e8a6d5a92b7201cb4e05abbd581960d064", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HBR.Persistence.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Menu/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section>\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 207, "\"", 215, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 style=\"text-align:center\">PERFIL DE USUARIO</h2>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
         using (Html.BeginForm("Edit", "Users", FormMethod.Post, new { onkeydown = "return event.keyCode!=13" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row clearfix"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <div class=""card"">
                        <div class=""body"">
                            <div class=""row clearfix"">

                                <div class=""col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Nombre</label>
                                        <input type=""text"" name=""_Name"" id=""nombre""");
            BeginWriteAttribute("value", " value=\"", 1051, "\"", 1071, 1);
#nullable restore
#line 29 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
WriteAttributeValue("", 1059, Model._Name, 1059, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled>
                                    </div>
                                </div>
                                <div class=""col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Apellido</label>
                                        <input type=""text"" name=""LastName""");
            BeginWriteAttribute("value", " value=\"", 1446, "\"", 1469, 1);
#nullable restore
#line 35 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
WriteAttributeValue("", 1454, Model.LastName, 1454, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled>
                                    </div>
                                </div>

                            </div>
                            <div class=""row clearfix"">

                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Telefono</label>
                                        <input type=""text"" name=""Telephone""");
            BeginWriteAttribute("value", " value=\"", 1941, "\"", 1965, 1);
#nullable restore
#line 45 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
WriteAttributeValue("", 1949, Model.Telephone, 1949, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled>
                                    </div>
                                </div>

                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Correo Electronico</label>
                                        <input type=""text"" name=""Email""");
            BeginWriteAttribute("value", " value=\"", 2349, "\"", 2369, 1);
#nullable restore
#line 52 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
WriteAttributeValue("", 2357, Model.Email, 2357, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Contraseña</label>
                                        <input type=""text"" name=""_Password""");
            BeginWriteAttribute("value", " value=\"", 2747, "\"", 2771, 1);
#nullable restore
#line 58 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
WriteAttributeValue("", 2755, Model._Password, 2755, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""row clearfix"">


                        <div class=""col-sm-12"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 3118, "\"", 3156, 2);
            WriteAttributeValue("", 3125, "\\Users\\Edit?id=", 3125, 15, true);
#nullable restore
#line 69 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
WriteAttributeValue("", 3140, ViewBag.Message, 3140, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""Editar"" type=""button"" class=""btn btn-outline-primary"">Editar Perfil</a>
                            <button type=""button"" class=""btn btn-outline-primary"" id=""btn_cancelar"">Regresar</button>
                        </div>
                    </div>
                </div>

            </div>
");
#nullable restore
#line 76 "C:\Users\Adelyn\source\repos\HBR.Project\HBR.Project\Views\Users\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e50022d0d04dbb9d8becbde3ac51d6070a94c88410010", async() => {
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
            WriteLiteral("<script type=\"text/javascript\">\r\n\r\n    $(document).ready(function () {\r\n\r\n        $(\'#btn_cancelar\').click(function () {\r\n            window.location.href = \'/Home/Index\';\r\n        })\r\n\r\n\r\n    })\r\n\r\n</script>");
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
