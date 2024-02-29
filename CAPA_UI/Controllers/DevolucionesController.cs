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
    public class DevolucionesController : ControllerBase
    {
        private readonly IDevolucionMaestroDetalle _Devolucion;
        public DevolucionesController
        (
            IDevolucionMaestroDetalle Devolucion
        ) 
        {

            _Devolucion = Devolucion;
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
    }
 }

    

