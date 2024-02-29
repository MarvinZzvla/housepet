#pragma checksum "C:\Users\Zavala\Desktop\Desarrollo\HOUSEPET\PetHouse\CAPA_UI\Pages\Informes\ViewInformeCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596d2197b628d0109f2206498c0fb13ae1c92f1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CAPA_UI.Pages.Informes.Pages_Informes_ViewInformeCompra), @"mvc.1.0.razor-page", @"/Pages/Informes/ViewInformeCompra.cshtml")]
namespace CAPA_UI.Pages.Informes
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596d2197b628d0109f2206498c0fb13ae1c92f1e", @"/Pages/Informes/ViewInformeCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7aa5bdf3122fd2be8c0f9b4f55854e40f0f0ca", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Informes_ViewInformeCompra : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script type=""module"">
	import CreateTableInforme from ""../../wwwroot/js/InformeComponent.js""
		
	
	window.onload = async () => {
		CargarDatos();
		BtnUpdate.onclick = () => {
			CargarDatos();
			
		}
		BtnPrint.onclick = () =>
		{
			
			const PrintNode = Page.innerHTML;
			const ventimp = window.open (' ', 'popimpr');
			ventimp.document.write(PrintNode);
			ventimp.document.close();
			ventimp.print();
			ventimp.close();
		}
	}
</script>
<script>
async function setDates()
{
	console.log('dasdasda')
	document.getElementById('Fecha1').value = new Date().toISOString().substring(0, 10);
            document.getElementById('Fecha2').value = new Date().toISOString().substring(0, 10);
}
	async function GetDataValues(){
		;(async () => {
          const response = await CargarDatos();
		  
		   var k = '<tbody>'
              for(i = 0;i < response.length; i++){
                  k+= '<tr>';
                  k+= '<td>' + response[i].id + '</td>';
                  k+= '<t");
            WriteLiteral(@"d>' + response[i].proveedor + '</td>';
                  k+= '<td>' + response[i].fechaCompra + '</td>';
				  k+= '<td>' + response[i].iva + '</td>';
				  k+= '<td>' + response[i].descuento + '</td>';
				  k+= '<td>' + response[i].total + '</td>';
                  k+= '</tr>';
              }
              k+='</tbody>';
              document.getElementById('tableData').innerHTML = k;
		  
        })();
	}
	
	const CargarDatos = async () => {
    		let UrlP = ""../api/Informes/TakeInformeCompras"";
			
    		const ObjInst = {
    			Params:[Fecha1.value, Fecha2.value]
    		}
    		let response = await fetch(UrlP, {
    			method: ""POST"",
    			headers:{
    				'Content-Type': ""application/json; charset=utf-8"",
    				'Accept': """"
    			},
    			body: JSON.stringify(ObjInst)
    		});
    		response = await response.json();
    		console.log(response);
    		labelSubtitle.innerText = `INFORME DE COMPRAS HOUSE PETS
    		Del ${Fecha1.value} al ${Fecha2.value}`;
    		
  ");
            WriteLiteral(@"  		let sum = 0;
    		response.forEach(element => {
    			sum = sum + element.total;
    		});
    
    		LabelTotal.append("" "" + sum)
    		return response;
    	}
</script>

<div class=""FrmContainer"">
	<input type=""date"" id=""Fecha1"" class=""form-control-sm"" value=""2023-01-01""/>
	<input type=""date"" id=""Fecha2"" class=""form-control-sm"" value=""2024-01-01""/>
</div>

<div class=""FrmContainer"">
	<input class=""btn-success"" type=""button"" id=""BtnPrint"" value=""Imprimir""/>
	<input class=""btn-success"" type=""button"" id=""BtnUpdate"" onclick=""GetDataValues()"" value=""Actualizar""/>
</div>

<div class=""InformeContainer"">
	<div class=""page"" id=""Page"">
		<style>
			.InformeContainer{
				background-color: #b99b9b;
				padding: 20px;
				height:600px;
				overflow:auto;
				border:solid 2px #888;
			}
			.page{
				background-color:#fff;
				width:22cm;
				height:25.7cm;
				display:block;
				margin: 0 auto;
				margin-bottom: 0.5cm;
				box-shadow:0 0 0.5cm rgba(0,0,0,0.5);
				padding: 1");
            WriteLiteral(@"cm 2cm;
			}
			h1, h4{
				text-align:center;
			}
			.TableInforme{
				width:100%;
				margin-bottom:30px;
			}

			.TableInforme td, .TableInforme th{
				border-bottom:solid 1px #b9b9b9;
			}
		</style>
		<section>
			<h4 id=""labelSubtitle"">INFORME DE COMPRAS HOUSE PETS</h4>
			<table id=""TableData"" class=""TableInforme"">
				<thead>
				<thead>
                    <tr>
                        <th>ID de compra</th>
                        <th>Proveedor</th>
                        <th>Fecha de compra</th>
                        <th>IVA</th>
                        <th>Descuento</th>
                        <th>Total</th>
                    </tr>
                </thead>
				 <tbody id=""tableData""></tbody>
			</table>
		<hr />
		<label id=""LabelTotal""> Total: </label>
		</section>
	</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Informes_ViewInformeCompra> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Informes_ViewInformeCompra> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Informes_ViewInformeCompra>)PageContext?.ViewData;
        public Pages_Informes_ViewInformeCompra Model => ViewData.Model;
    }
}
#pragma warning restore 1591