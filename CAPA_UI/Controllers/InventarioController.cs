using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CAPA_UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        public string _Cnn;
        public InventarioController(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
            
        }

        [HttpPost]
        public void SaveInventario(object Inst)
        {
            string connectionString = _Cnn;
            string queryString = "UPDATE DETALLE_COMPRA SET CANTIDAD_COMPRA += @cantidad WHERE FK_CAT_ARTICULO = @idCompra AND ID = (SELECT MAX(ID) FROM DETALLE_COMPRA WHERE FK_CAT_ARTICULO = @idCompra);";
            GetInventario fnn = JsonConvert.DeserializeObject<GetInventario>(Inst.ToString());
          

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@idCompra", fnn.id);
                command.Parameters.AddWithValue("@cantidad", fnn.cantidad);
                connection.Open();
                command.ExecuteReader();

            }

        }

        public class GetInventario {
            public int id { get; set; }
            public int cantidad { get; set; }
        }
      
    }
}
