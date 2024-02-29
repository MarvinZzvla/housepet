using System.Collections.Generic;
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
    public class ComprasController : ControllerBase
    {
        
        private readonly ICompraMaestroDetalle _Compra;
        private readonly IVentaMaestroDetalle _Venta;
        private readonly IDevolucionMaestroDetalle _Devolucion;
        public List<RptComprasDto> RptComprasDto = new List<RptComprasDto>();
        
        
        public void OnGet()
        {
            RptComprasDto = new List<RptComprasDto>();
        }
        
        public ComprasController
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
            /*RptComprasDto = ObjInst.TakeInforme(ObjInst);
            return true;*/
        }
    }
 }

    

