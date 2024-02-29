using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CAPA_UI.Pages.Catalogos
{
    public class BodegaModel : PageModel
    {
        public string _Cnn;

        public List<BodegaModelInfo> listInfor = new List<BodegaModelInfo>();

        public BodegaModel(IConfiguration config)
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
                    var sql = "SELECT * FROM CAT_BODEGA";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new BodegaModelInfo();
                                info.IdBodega = reder.GetInt32(0);
                                info.DescipcionBodega = reder.GetString(1);
                                info.EstadoBodega = reder.GetString(2);
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

        public class BodegaModelInfo
        {
            public string DescipcionBodega;
            public string EstadoBodega;
            public int IdBodega;
        }
    }
}