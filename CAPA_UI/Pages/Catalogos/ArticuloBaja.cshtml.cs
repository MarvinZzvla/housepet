using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CAPA_UI.Pages.Catalogos
{
    public class ArticuloBajaModel : PageModel
    {
        public string _Cnn;

        public List<ArticuloBajaModelInfo> listInfor = new List<ArticuloBajaModelInfo>();

        public ArticuloBajaModel(IConfiguration config)
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
                    var sql = "SELECT * FROM ARTICULO_BAJA";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new ArticuloBajaModelInfo();
                                info.Id_baja = reder.GetInt32(0);
                                info.Id_articulo = reder.GetInt32(1);
                                info.FechaBaja = new DateTime(2);
                                info.DescripcionBaja = reder.GetString(3);


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

        public class ArticuloBajaModelInfo
        {
            public string DescripcionBaja;
            public DateTime FechaBaja;
            public int Id_articulo;
            public int Id_baja;
        }
    }
}