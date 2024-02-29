using CAPA_NEGOCIOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CAPA_UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccessController : ControllerBase
    {

        [HttpPost]
        public object SaveUsuario(object ObjInst)
        {
            Usuario Inst = JsonConvert.DeserializeObject<Usuario>(ObjInst.ToString());
            Inst.SaveUsuario(Inst);

            return true;
        }
    }
}
