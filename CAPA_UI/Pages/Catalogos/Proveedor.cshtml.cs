using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CAPA_UI.Pages.Catalogos
{
    public class ProveedorModel : PageModel
    {
        public string _Cnn;
        public List<ProveedoaModelInfo> listInfor = new List<ProveedoaModelInfo>();

        public ProveedorModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }

        public void OnGet()
        {
            try
            {
                var connectionString = _Cnn;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var sql = "SELECT * FROM CAT_PROVEEDOR";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new ProveedoaModelInfo();
                                info.IdProveedor = reder.GetInt32(0);
                                info.NombrePorveedor = reder.GetString(1);
                                info.TelefonoOProveedor = reder.GetString(2);
                                info.TelefonoCProveedor = reder.GetString(3);
                                info.DireccionProveedor = reder.GetString(4);
                                info.RUCProveedor = reder.GetString(5);
                                info.EstadoProveedor = reder.GetString(6);

                                listInfor.Add(info);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public class ProveedoaModelInfo
        {
            public string DireccionProveedor;
            public string EstadoProveedor;
            public int IdProveedor;
            public string NombrePorveedor;
            public string RUCProveedor;
            public string TelefonoCProveedor;
            public string TelefonoOProveedor;
        }
    }
}