#pragma checksum "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Compras\Factura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08456510daaf664e3988028f3140254b7793c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CAPA_UI.Pages.Compras.Pages_Compras_Factura), @"mvc.1.0.razor-page", @"/Pages/Compras/Factura.cshtml")]
namespace CAPA_UI.Pages.Compras
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08456510daaf664e3988028f3140254b7793c3f", @"/Pages/Compras/Factura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7aa5bdf3122fd2be8c0f9b4f55854e40f0f0ca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Compras_Factura : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo_factura"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
    .factura_box {
        width: 920px;
        height:auto;
        background-color:white;
        margin-top:50px;
        margin-bottom: 25px;
        border-radius: 10px;
        padding: 25px;
        align-content:center;
    }
    div.factura_box h3{
        font-family: ""Lucida Console"", ""Courier New"", monospace;
    }

    div.factura_box hr{
        border-style: solid;
        border-color: black;
        border-width: 5px 0px 0px 0px;
    }

    #doted{
        border-style: dashed;
    }

    #logo_factura {
        width:120px;
        height:72px;
        margin-left: auto;
        margin-right: auto;
    }
</style>
<div class=""factura_box"">
<h1 style=""text-align:center;"">HOUSE PETS</h1>
 
    <div style=""width:auto;height:auto; margin:0px auto;text-align:center;padding:20px;"">
        <h3 id=""idVenta"">Nº00001</h3>
        <h3>Catarina - 42500 </h3>
        <h3 id=""fecha_factura_auth"">2022/05/04</h3>
          <hr/>
    </div>
    <h2 style=""");
            WriteLiteral(@"text-align:center;"">Factura de la Compras</h2>
    <hr />
    <div style=""width:auto;height:auto; margin:0px auto;text-align:left;padding:20px;"">
        <h3 id=""fecha_factura"">2022/05/04</h3>
        <h3>Direccion: Parque central 1c. al Norte 1/2 al Este</h3>
    </div>
    <hr />
    <div style=""width:auto;height:auto; margin:0px auto;text-align:left; padding:20px;"">
        <h3 id=""producto_factura"">Productos:</h3>
        <h3 id=""iva_factura"">Iva:</h3>
        <h3 id=""descuento_factura"">Descuento:</h3>
        <hr id=""doted""/>
        <h3 id=""total_factura"">Total:</h3>
    </div>
<center>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f08456510daaf664e3988028f3140254b7793c3f6092", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</center>
<p style=""text-align:center;"">Gracias por tu compra👍</p>
</div>
<button class=""btn btn-success"" onclick=""redirect()"">Volver</button>
<button class=""btn btn-success"" onclick=""printFactura()"">Imprimir</button>
<script>

    const queryString = window.location.search;
    const urlParams = new URLSearchParams(queryString);
    const id = urlParams.get('id')
    //console.log(id);
    LoadValues(id)

    async function LoadValues(item){
         let articulosList = JSON.parse('");
#nullable restore
#line 75 "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Compras\Factura.cshtml"
                                    Write(Html.Raw(Json.Serialize(Model.listInfor)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"') 
         var productosList = []
         /****Desarrollo Nuevo*/
         for(let i = 0; i < articulosList.length; i++){
             if(articulosList[i].idCabVenta == item){
                 productosList.push(articulosList[i])
             } 
         }
         console.log(productosList)

         /******* */
           console.log(articulosList)
         let articulo = articulosList.find(x => x.idCabVenta === parseInt(item))
        //document.getElementById(""TxId"").innerHTML = ""I have changed!"";
        console.log(articulo);
        document.getElementById(""idVenta"").innerHTML = ""Nº 0000"" + articulo.idCabVenta
        document.getElementById(""fecha_factura"").innerHTML = ""Fecha de la Compras: "" + articulo.fechaVenta
        document.getElementById(""fecha_factura_auth"").innerHTML = ""Fecha Autorizada: "" + articulo.fechaVenta
        //document.getElementById(""producto_factura"").innerHTML = ""Producto: "" + articulo.nombreArticulo
        for (let i = 0; i < productosList.length; i++) {");
            WriteLiteral(@"
        document.getElementById(""producto_factura"").innerHTML +=""<li>""+productosList[i].nombreArticulo+""</li>"" 
        }
        document.getElementById(""iva_factura"").innerHTML = ""Iva: "" + articulo.ivaVenta
        document.getElementById(""descuento_factura"").innerHTML = ""Descuento: "" + articulo.descuentoVenta
        document.getElementById(""total_factura"").innerHTML = ""Total: "" + articulo.totalVenta
    }

    function redirect(){
        window.location.replace(""./ComprasIndex"")
    }

    function printFactura(){
        window.print()
    }

</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FacturaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FacturaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FacturaModel>)PageContext?.ViewData;
        public FacturaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
