using CAPA_NEGOCIOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using CAPA_NEGOCIOS.Dto;
using CAPA_NEGOCIOS.InterfacesMaestrosDetalles;
using CAPA_NEGOCIOS.Entidades;

namespace CAPA_UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        
        private readonly ICompraMaestroDetalle _Compra;
        private readonly IVentaMaestroDetalle _Venta;
        private readonly IDevolucionMaestroDetalle _Devolucion;
        public CatalogosController
        (
            ICompraMaestroDetalle Compra,
            IVentaMaestroDetalle Venta,
            IDevolucionMaestroDetalle Devolucion
        ) 
        {
            _Compra = Compra;
            _Venta = Venta;
            _Devolucion = Devolucion;
        }
        //Acciones del catalogo talla
        [HttpPost]
        public object SaveTalla(object ObjInst)
        {
            CatTalla Inst = JsonConvert.DeserializeObject<CatTalla>(ObjInst.ToString());
            Inst.Save(Inst);
            return true;
        }
        [HttpGet]
        public object GetTalla(object ObjInst)
        {
            CatTalla Inst = JsonConvert.DeserializeObject<CatTalla>(ObjInst.ToString());
            Inst.GetTalla(Inst);
            return true;
        }


        //Acciones del catalogo Bodega
        [HttpPost]
        public object SaveBodega(object ObjInst)
        {
            CatBodega Inst = JsonConvert.DeserializeObject<CatBodega>(ObjInst.ToString());
            Inst.SaveBodega(Inst);
            return true;
        }
        [HttpGet]
        public object GetBodega(object ObjInst)
        {
            CatBodega Inst = JsonConvert.DeserializeObject<CatBodega>(ObjInst.ToString());
            Inst.GetBodega(Inst);
            return true;
        }

        //Acciones del Catalogo Categoria
        [HttpPost]
        public object SaveCategoria(object ObjInst)
        {
            CatCategoria Inst = JsonConvert.DeserializeObject<CatCategoria>(ObjInst.ToString());
            Inst.SaveCategoria(Inst);
            return true;
        }
        [HttpGet]
        public object GetCategoria(object ObjInst)
        {
            CatCategoria Inst = JsonConvert.DeserializeObject<CatCategoria>(ObjInst.ToString());
            Inst.GetCategoria(Inst);
            return true;
        }

        //Acciones del Catalogo Proveedor
        [HttpPost]
        public object SaveProveedor(object ObjInst)
        {
            CatProveedor Inst = JsonConvert.DeserializeObject<CatProveedor>(ObjInst.ToString());
            Inst.SaveProveedor(Inst);
            return true;
        }
        [HttpGet]
        public object GetProveedor(object ObjInst)
        {
            CatProveedor Inst = JsonConvert.DeserializeObject<CatProveedor>(ObjInst.ToString());
            Inst.GetProveedor(Inst);
            return true;
        }

        //Acciones del Catalogo de Articulos
        [HttpPost]
        public object SaveArticulo(object ObjInst)
        {
            CatArticulo Inst = JsonConvert.DeserializeObject<CatArticulo>(ObjInst.ToString());
            Inst.SaveArticulo(Inst);
            return true;
        }
        [HttpGet]
        public object GetArticulo(object ObjInst)
        {
            CatArticulo Inst = JsonConvert.DeserializeObject<CatArticulo>(ObjInst.ToString());
            Inst.GetArticulo(Inst);
            return true;
        }
        [HttpPut]
        public object UpdateArticulo([FromBody] int Id)
        {
            return new { result =  $"Probando Consumo de articulo {Id}" };
        }
        [HttpDelete]
        public object DeleteArticulo([FromBody] int Id)
        {
            return new { result = $"Probando Delete de articulo {Id}" };
        }

        //Acciones de Referencias de Catalogo Articulo Bodega
        [HttpPost]
        public object SaveArticuloBodega(object ObjInst)
        {
            RefArticuloBodega Inst = JsonConvert.DeserializeObject<RefArticuloBodega>(ObjInst.ToString());
            Inst.SaveArticuloBodega(Inst);
            return true;
        }
        [HttpGet]
        public object GetArticuloBodega(object ObjInst)
        {
            RefArticuloBodega Inst = JsonConvert.DeserializeObject<RefArticuloBodega>(ObjInst.ToString());
            Inst.GetArticuloBodega(Inst);
            return true;
        }

        //Acciones de Referencias de Catalogo Proveedor Articulo
        [HttpPost]
        public object SaveProveedorArticulo(object ObjInst)
        {
            RefProveedorArticulo Inst = JsonConvert.DeserializeObject<RefProveedorArticulo>(ObjInst.ToString());
            Inst.SaveProveedorArticulo(Inst);
            return true;
        }
        [HttpGet]
        public object GetProveedorArticulo(object ObjInst)
        {
            RefArticuloBodega Inst = JsonConvert.DeserializeObject<RefArticuloBodega>(ObjInst.ToString());
            Inst.GetArticuloBodega(Inst);
            return true;
        }

        //Acciones de Referencias de Catalogo Talla Articulo
        [HttpPost]
        public object SaveTallaArticulo(object ObjInst)
        {
            RefTallaArticulo Inst = JsonConvert.DeserializeObject<RefTallaArticulo>(ObjInst.ToString());
            Inst.SaveTallaArticulo(Inst);
            return true;
        }

        [HttpGet]
        public object GetTallaArticulo(object ObjInst)
        {
            RefTallaArticulo Inst = JsonConvert.DeserializeObject<RefTallaArticulo>(ObjInst.ToString());
            Inst.GetTallaArticulo(Inst);
            return true;
        }

        //ACCIONES DE ARTICULO BODEGA

        [HttpPost]
        public object ArticuloBodega(object ObjInst)
        {
            RefArticuloBodega Inst = JsonConvert.DeserializeObject<RefArticuloBodega>(ObjInst.ToString());
            Inst.SaveArticuloBodega(Inst);
            return true;
        }

        [HttpGet]
        public object GetSaveArticuloBodega(object ObjInst)
        {
            RefArticuloBodega Inst = JsonConvert.DeserializeObject<RefArticuloBodega>(ObjInst.ToString());
            Inst.GetArticuloBodega(Inst);
            return true;
        }

        //Acciones del Catalogo de Baja Articulos
        //public IActionResult BajaArticulo()
        //{
        //    return View();
        //}

        //ACCIONES DE ARTICULO BAJA

        [HttpPost]
        public object ArticuloBaja(object ObjInst)
        {
            RefArticuloBaja Inst = JsonConvert.DeserializeObject<RefArticuloBaja>(ObjInst.ToString());
            Inst.SaveArticuloBaja(Inst);
            return true;
        }
        [HttpGet]
        public object GetSaveBajaArticulo(object ObjInst)
        {
            RefArticuloBaja Inst = JsonConvert.DeserializeObject<RefArticuloBaja>(ObjInst.ToString());
            Inst.GetArticuloBaja(Inst);
            return true;
        }

        //Maestro Detalles


        /// <summary>
        /// Crea una Compra
        /// </summary>
        /// <param name="Request"></param>
        /// <returns></returns>

        [HttpPost]
        public object SaveCompra([FromBody]CompraMaestroDetalleDto Request)
        {
            _Compra.Crear(Request);
            return new { response = true };
        }

        /// <summary>
        /// Crea una Venta
        /// </summary>
        /// <param name="Request"></param>
        /// <returns></returns>
        [HttpPost]
        public object SaveVenta([FromBody] VentaMaestroDetalleDto Request)
        {
            _Venta.Crear(Request);
            return new { response = true };
        }

        /// <summary>
        /// Crea una Devolucion
        /// </summary>
        /// <param name="Request"></param>
        /// <returns></returns>
        [HttpPost]
        public object SaveDevolucion([FromBody] DevolucionMaestroDetalleDto Request)
        {
            _Devolucion.Crear(Request);
            return new { response = true };
        }


		[HttpPost]
		public object TakeInformeCompras(InformeCompras ObjInst)
		{
			return ObjInst.TakeInforme(ObjInst);
		}

        [HttpPost]
        public object ProbarArticulo(object ObjInst)
        {
          
            return true;
        }





    }
 }

    

