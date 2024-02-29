using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CAPA_UI.Pages.Catalogos
{
    public class CategoriaModel : PageModel
    {
        public string _Cnn;


        public List<CategoriaModelInfo> listInfor = new List<CategoriaModelInfo>();

        public CategoriaModel(IConfiguration config)
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
                    var sql = "SELECT * FROM CAT_CATEGORIA";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new CategoriaModelInfo();
                                info.IdCategoria = reder.GetInt32(0);
                                info.DescipcionCategoria = reder.GetString(1);
                                info.EstadoCategoria = reder.GetString(2);


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


        public class CategoriaModelInfo
        {
            public string DescipcionCategoria;
            public string EstadoCategoria;
            public int IdCategoria;
        }
    }
}