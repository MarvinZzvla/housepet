
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

namespace CAPA_UI.Pages
{
    public class IndexModel : PageModel
    {
       // private readonly ILogger<IndexModel> _logger;

        public string _Cnn;
        public List<UsuarioModelInfo> listInfor = new List<UsuarioModelInfo>();


        public void OnGet()
        {
            ListarUsuario();
        }

        public IndexModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }



        private void ListarUsuario()
        {
            try
            {
                var connectionString = _Cnn;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var sql = "SELECT * FROM USUARIO";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new UsuarioModelInfo();
                                info.IdUsuario = reder.GetInt32(0);
                                info.NombreCompleto = reder.GetString(1);
                                info.Correo = reder.GetString(2);
                                info.Clave = reder.GetString(3);
                                info.Fecha = reder.GetDateTime(4);
                                

                                listInfor.Add(info);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public class UsuarioModelInfo
        {

            public int IdUsuario;
            public string NombreCompleto;
            public string Correo;
            public string Clave;
            public DateTime Fecha;
          
        }

        
    }
}
