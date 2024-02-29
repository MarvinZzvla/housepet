using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CAPA_UI.Pages.Catalogos
{
    public class TallaModel : PageModel
    {
        public string _Cnn;


        public List<TallaModelInfo> listInfor = new List<TallaModelInfo>();

        public TallaModel(IConfiguration config)
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
                    var sql = "SELECT * FROM CAT_TALLA";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new TallaModelInfo();
                                info.IdTalla = reder.GetInt32(0);
                                info.DescipcionTalla = reder.GetString(1);
                                info.EstadoTalla = reder.GetString(2);


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


        public class TallaModelInfo
        {
            public string DescipcionTalla;
            public string EstadoTalla;
            public int IdTalla;
        }
    }
}