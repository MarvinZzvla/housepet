#pragma checksum "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46eee7ff43ff67885ce564db6cacfc19ddd52fe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CAPA_UI.Pages.Catalogos.Pages_Catalogos_Proveedor), @"mvc.1.0.razor-page", @"/Pages/Catalogos/Proveedor.cshtml")]
namespace CAPA_UI.Pages.Catalogos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46eee7ff43ff67885ce564db6cacfc19ddd52fe6", @"/Pages/Catalogos/Proveedor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7aa5bdf3122fd2be8c0f9b4f55854e40f0f0ca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Catalogos_Proveedor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\"", 93, "\"", 138, 1);
#nullable restore
#line 7 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
WriteAttributeValue("", 99, Url.Content("../js/TablaComponent.js"), 99, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>

    <script type=""module"">
        window.onload = async () => {
            let UrlP = ""../api/Catalogos/SaveProveedor"";
            let response = await fetch(UrlP, {
                method: ""GET"",
                headers: {
                    'Content-Type': ""application/json; charset-utf-8"",
                    'Accept': ""*/*""
                }
            });
            response = await response.json();
            console.log(response)
            CreateTable(response, TableData)

        }

        const reload = document.getElementById('Editar');

        reload.addEventListener('click', _ => { // el _ es para indicar la ausencia de parametros
            //location.reload();
        });
    </script>
    <script>
        window.edit = async () => {

               if(checkFields()){alert(""Porfavor rellenen todos los campos"");return}

                    const ObjInst = {
                        Parametro: TxOperacion.value.length === 1 ? TxOperacion.value :");
                WriteLiteral(@" 'C',
                        IdProveedor: TxtId.value.length > 0 ? TxtId.value : 1,
                        NombreProveedor: TxtNombre.value,
                        TelefonoProveedor: TxtTelefonoTel.value,
                        CelularProveedor: TxtTelefonoCel.value,
                        DireccionProveedor: TxtDireccion.value,
                        RucProveedor: TxtRuc.value,
                        EstadoProveedor: TxtEstado.value
                    }
        
                    let Url = ""../api/Catalogos/SaveProveedor"";
                    let response = await fetch(Url,
                        {
                            method: ""POST"",
                            headers: {
                                'Content-Type': ""application/json; charset=utf-8"",
                                'Accept': ""*//*""
                            },
                            body: JSON.stringify(ObjInst)
                        });
                    window.location.reload();
       ");
                WriteLiteral(@"                
        }
          function checkFields(){
            return (TxtNombre.value == '' || TxtTelefonoTel.value == '' || 
            TxtTelefonoCel.value == '' || TxtDireccion.value == '' || TxtRuc.value == '')
        }
        async function LoadValues(item)
        {
            window.scrollTo(0, 0);
            console.log(item);
            let listItems = JSON.parse('");
#nullable restore
#line 68 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
                                   Write(Html.Raw(Json.Serialize(@Model.listInfor)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
            console.log(listItems);
            let singleItem = listItems.find(x => x.idProveedor === item);
            
            TxtNombre.value = singleItem.nombrePorveedor;
            TxtTelefonoTel.value = singleItem.telefonoOProveedor;
            TxtTelefonoCel.value = singleItem.telefonoCProveedor;
            TxtDireccion.value = singleItem.direccionProveedor;
            TxtRuc.value = singleItem.rucProveedor;
            TxtEstado.value = singleItem.estadoProveedor;
           
            TxOperacion.value = 'U';
            TxtId.value = singleItem.idProveedor;
           
            var _modalHeader = document.getElementById(""modalHeader"");
            _modalHeader.textContent = ""Editar Proveedor"";   
        }

        </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("<div class=\"row\" id=\"ModalProveedor\">\r\n    <div class=\"modal-dialog modal-lg \">\r\n        <div class=\" modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eee7ff43ff67885ce564db6cacfc19ddd52fe68931", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h2 class=""modal-title text-primary text-center"" id=""modalHeader"">Ingresar Proveedor</h2>
                </div>
                <div class=""modal-body"">
                    <div>
                        <div class=""row p-3 border-0"">
                            <div class=""text-danger""></div>
                        </div>

                        <input type=""hidden"" class=""form-control"" id=""TxtId""/>

                        <div class=""form-row"" style=""padding-top:14px;"">
                            <div class=""form-group col-md-6"">
                                <label>Nombre</label>
                                <input type=""text"" id=""TxtNombre"" class=""form-control"" placeholder=""Nombre""/>
                                <span class=""text-danger""></span>
                            </div>

                            <div class=""form-group col-md-6"">
                                <label>Oficina</label>
              ");
                WriteLiteral(@"                  <input type=""number"" id=""TxtTelefonoTel"" class=""form-control"" placeholder=""Ingrese el Contacto de la Oficina""/>
                                <span class=""text-danger""></span>

                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Celular</label>
                                <input type=""number"" id=""TxtTelefonoCel"" class=""form-control"" placeholder=""Ingresar Celular""/>
                                <span class=""text-danger""></span>
                            </div>

                            <div class=""form-group col-md-6"">
                                <label>Direccion</label>
                                <input type=""text"" id=""TxtDireccion"" class=""form-control"" placeholder=""Direccion y Pais del Proveedor""/>
                                <span class=""text-danger""></span>
                            </div>

                            <div class=""form-group col-md-6"">
         ");
                WriteLiteral(@"                       <label>RUC</label>
                                <input type=""text"" id=""TxtRuc"" class=""form-control"" placeholder=""RUC""/>
                                <span class=""text-danger""></span>
                            </div>

                            <div>
                                <div class=""form-group"" style=""margin-left:10px"">
                                    <label>Estado</label>
                                    <select id=""TxtEstado"" class=""custom-select"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eee7ff43ff67885ce564db6cacfc19ddd52fe611949", async() => {
                    WriteLiteral("Activo");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eee7ff43ff67885ce564db6cacfc19ddd52fe613213", async() => {
                    WriteLiteral("Inactivo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>

                                </div>
                            </div>
                            <input type=""hidden"" id=""TxOperacion"" class=""form-control""/>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"">Cancelar</button>
                    <button type=""button"" class=""btn btn-success"" id=""Editar"" formmethod=""post"" onclick=""edit()"">Grabar Cambios</button>
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

    </div>
</div>


<table class=""table table-dark"">
    <thead>
    <tr>
        <th>ID</th>
        <th>Nombre</th>
        <th>Telefono oficina</th>
        <th>Telefono Celular</th>
        <th>Direccion</th>
        <th>RUC</th>
        <th>Estado</th>
        <th>Accion</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 178 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
     foreach (var item in Model.listInfor)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 182 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
           Write(item.IdProveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 185 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
           Write(item.NombrePorveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 188 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
           Write(item.TelefonoOProveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 191 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
           Write(item.TelefonoCProveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 194 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
           Write(item.DireccionProveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 197 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
           Write(item.RUCProveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 200 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
           Write(item.EstadoProveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7997, "\"", 8036, 3);
            WriteAttributeValue("", 8007, "LoadValues(", 8007, 11, true);
#nullable restore
#line 203 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
WriteAttributeValue("", 8018, item.IdProveedor, 8018, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8035, ")", 8035, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 207 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Proveedor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProveedorModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProveedorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProveedorModel>)PageContext?.ViewData;
        public ProveedorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
