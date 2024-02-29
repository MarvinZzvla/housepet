using CAPA_NEGOCIOS.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CAPA_UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InformesController : Controller
    {
        public InformesController() {
            
        }

        [HttpPost]
        public object TakeInformeCompras(InformeCompras ObjInst)
        {
            return ObjInst.TakeInforme(ObjInst);
        }
        
        [HttpPost]
        public object TakeInformeVentas(InformeCompras ObjInst)
        {
            return ObjInst.TakeInformeVentas(ObjInst);
        }
        
        [HttpPost]
        public object TakeInformeExistencias(InformeCompras ObjInst)
        {
            return ObjInst.TakeInformeExistencias(ObjInst);
        }
    }
}
