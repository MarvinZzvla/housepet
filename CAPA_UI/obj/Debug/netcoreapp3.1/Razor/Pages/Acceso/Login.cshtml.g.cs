#pragma checksum "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Acceso\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f955f0f7011bfe7d185a20a8b357c8a955780409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CAPA_UI.Pages.Acceso.Pages_Acceso_Login), @"mvc.1.0.razor-page", @"/Pages/Acceso/Login.cshtml")]
namespace CAPA_UI.Pages.Acceso
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
#line 1 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\_ViewImports.cshtml"
using CAPA_UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f955f0f7011bfe7d185a20a8b357c8a955780409", @"/Pages/Acceso/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7aa5bdf3122fd2be8c0f9b4f55854e40f0f0ca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Acceso_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Acceso\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f955f0f7011bfe7d185a20a8b357c8a9557804093943", async() => {
                WriteLiteral(@"
    <title>LOGIN</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.1/css/all.css"" integrity=""sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP"" crossorigin=""anonymous"">
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <link href=""./css/Login.css"" rel=""stylesheet"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f955f0f7011bfe7d185a20a8b357c8a9557804095646", async() => {
                WriteLiteral(@"
    <div class=""container h-100"">
        <div class=""d-flex justify-content-center h-100"">
            <div class=""user_card"">
                <div class=""d-flex justify-content-center"">
                    <div class=""brand_logo_container"">
                        <img src=""https://cdn.freebiesupply.com/logos/large/2x/pinterest-circle-logo-png-transparent.png"" class=""brand_logo"" alt=""Logo"">
                    </div>
                </div>
                <div class=""d-flex justify-content-center form_container"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f955f0f7011bfe7d185a20a8b357c8a9557804096471", async() => {
                    WriteLiteral(@"
                        <div class=""input-group mb-3"">
                            <div class=""input-group-append"">
                                <span class=""input-group-text""><i class=""fas fa-envelope""></i></span>
                            </div>
                            <input type=""text"" name=""Correo"" class=""form-control input_user""");
                    BeginWriteAttribute("value", " value=\"", 1812, "\"", 1820, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""Correo"">
                        </div>
                        <div class=""input-group mb-2"">
                            <div class=""input-group-append"">
                                <span class=""input-group-text""><i class=""fas fa-key""></i></span>
                            </div>
                            <input type=""password"" name=""Clave"" class=""form-control input_pass""");
                    BeginWriteAttribute("value", " value=\"", 2224, "\"", 2232, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Contraseña\">\r\n                        </div>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Acceso\Login.cshtml"
                         if (ViewData["Mensaje"] != null)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Acceso\Login.cshtml"
                           Write(ViewData["Mensaje"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 50 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Acceso\Login.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        <div class=\"d-flex justify-content-center mt-3 login_container\">\r\n                            <button type=\"submit\" name=\"button\" class=\"btn login_btn\">Iniciar Sesion</button>\r\n                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Acceso\Login.cshtml"
AddHtmlAttributeValue("", 1416, Url.Action("Login","Acceso"), 1416, 29, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"mt-4\">\r\n                    <div class=\"d-flex justify-content-center links\">\r\n                        No tienes una cuenta <a");
                BeginWriteAttribute("href", " href=\"", 3017, "\"", 3057, 1);
#nullable restore
#line 60 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Acceso\Login.cshtml"
WriteAttributeValue("", 3024, Url.Action("Registrar","Acceso"), 3024, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""ml-2"">Registrarse</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CAPA_UI.Controllers.AccesoController> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CAPA_UI.Controllers.AccesoController> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CAPA_UI.Controllers.AccesoController>)PageContext?.ViewData;
        public CAPA_UI.Controllers.AccesoController Model => ViewData.Model;
    }
}
#pragma warning restore 1591
