#pragma checksum "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c4d5f417ca7ecbddff597667f6b579d0af6b41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CAPA_UI.Pages.Catalogos.Pages_Catalogos_Categoria), @"mvc.1.0.razor-page", @"/Pages/Catalogos/Categoria.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c4d5f417ca7ecbddff597667f6b579d0af6b41", @"/Pages/Catalogos/Categoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7aa5bdf3122fd2be8c0f9b4f55854e40f0f0ca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Catalogos_Categoria : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 7 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
WriteAttributeValue("", 99, Url.Content("../js/TablaComponent.js"), 99, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>

    <script type=""module"">
        window.onload = async () => {
            let UrlP = ""../api/Catalogos/GetCategoria"";
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
            location.reload();
        });;
    </script>
    <script>
            window.edit = async () => {
                const ObjInst = {
                    Parametro: TxOperacion.value.length === 1 ? TxOperacion.value : 'C',
                    IdCategoria: TxtId.value.length > 0 ? TxtId.value : 1,
                   ");
                WriteLiteral(@" DescipcionCategoria: TxtDescripcion.value,
                    EstadoCategoria: TxtEstado.value
                }
    
                console.log(ObjInst);
                let Url = ""../api/Catalogos/SaveCategoria"";
                let response = await fetch(Url,
                    {
                        method: ""POST"",
                        headers: {
                            'Content-Type': ""application/json; charset=utf-8"",
                            'Accept': ""*//*""
                        },
                        body: JSON.stringify(ObjInst)
                    });
            }
            
            async function LoadValues(item)
            {
                window.scrollTo(0, 0);
                console.log(item);
                let listItems = JSON.parse('");
#nullable restore
#line 54 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
                                       Write(Html.Raw(Json.Serialize(Model.listInfor)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
                console.log(listItems)
                let singleItem = listItems.find(x => x.idCategoria === item)
                TxtDescripcion.value = singleItem.descipcionCategoria;
                TxtEstado.value = singleItem.estadoCategoria;
                TxOperacion.value = 'U';
                TxtId.value = singleItem.idCategoria;
               
                var _modalHeader = document.getElementById(""modalHeader"");
                _modalHeader.textContent = ""Editar Categoria"";   
            }
            
    </script>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\" id=\"ModalCategoria\">\r\n    <div class=\"modal-dialog modal-lg \">\r\n        <div class=\" modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c4d5f417ca7ecbddff597667f6b579d0af6b418053", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h2 class=""modal-title text-primary text-center"" id=""modalHeader"">Agregar Categoria</h2>
                </div>
                <div class=""modal-body"">
                    <div>
                        <div class=""row p-3 border-0"">
                            <div class=""text-danger""></div>
                        </div>

                        <input type=""hidden"" class=""form-control"" id=""TxtId""/>

                        <div class=""form-row"" style=""padding-top:14px;"">
                            <div class=""form-group col-md-6"">
                                <label>Descripcion</label>
                                <input type=""text"" id=""TxtDescripcion"" class=""form-control"" placeholder=""Nombres""/>
                                <span class=""text-danger""></span>
                            </div>
                            <div>
                                <div class=""form-group"" style=""margin-left:10px"">
       ");
                WriteLiteral("                             <label>Estado</label>\r\n                                    <select id=\"TxtEstado\" class=\"custom-select\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c4d5f417ca7ecbddff597667f6b579d0af6b419588", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c4d5f417ca7ecbddff597667f6b579d0af6b4110851", async() => {
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

<table id=""example"" class=""table table-striped table-borderedk table-dark"">
    <thead>
    <tr>
        <th>ID</th>
        <th>Descripcion</th>
        <th>Estado</th>
        <th>
            <a>Accion</a>
        </th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 126 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
     foreach (var item in Model.listInfor)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
           Write(item.IdCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
           Write(item.DescipcionCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
           Write(item.EstadoCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5402, "\"", 5441, 3);
            WriteAttributeValue("", 5412, "LoadValues(", 5412, 11, true);
#nullable restore
#line 139 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
WriteAttributeValue("", 5423, item.IdCategoria, 5423, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5440, ")", 5440, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 142 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Catalogos\Categoria.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoriaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CategoriaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CategoriaModel>)PageContext?.ViewData;
        public CategoriaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
