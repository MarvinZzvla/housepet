using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CAPA_UI.Pages.Catalogos
{
    public class ArticuloBodegaModel : PageModel
    {
        public string _Cnn;
        public List<ArticuloBodegaModelInfo> listInfor = new List<ArticuloBodegaModelInfo>();

        public ArticuloBodegaModel(IConfiguration config)
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
                    var sql = "SELECT * FROM ARTICULO_BODEGA";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new ArticuloBodegaModelInfo();
                                info.Fk_Bodega = reder.GetInt32(0);
                                info.Fk_Articulo = reder.GetInt32(1);
                                info.Precioventa = reder.GetDecimal(2);
                                info.EstadoArticuloBodega = reder.GetString(3);
                                info.PesoArticulo = reder.GetString(4);
                                info.FechaVencArticuloBodega = reder.GetDateTime(5);
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

        public class ArticuloBodegaModelInfo
        {
            public string EstadoArticuloBodega;
            public DateTime FechaVencArticuloBodega;
            public int Fk_Articulo;
            public int Fk_Bodega;
            public string PesoArticulo;
            public decimal Precioventa;
        }
    }
}