using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CAPA_UI.Pages.Catalogos
{
    public class ArticuloModel : PageModel
    {
        public string _Cnn;
        public List<CategoriaModelInfo> Categorias;

        public List<ArticuloModelInfo> listInfor = new List<ArticuloModelInfo>();

        public List<TallaModelInfo> Tallas;

        public ArticuloModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }

        public void OnGet()
        {
            AgregarUsuario();
            SetearTallas();
            SetearCategorias();
        }


        private void AgregarUsuario()
        {
            try
            {
                var connectionString = _Cnn;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var sql = "SELECT * FROM CAT_ARTICULO";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new ArticuloModelInfo();
                                info.IdArticulo = reder.GetInt32(0);
                                info.NombreArticulo = reder.GetString(1);
                                info.DescripcionArticulo = reder.GetString(2);
                                info.EstadoArticulo = reder.GetString(3);
                                info.IdCategoria = reder.GetInt32(4);
                                info.IdTalla = reder.GetInt32(5);
                                info.IdBodega = reder.GetInt32(6);
                                info.PrecioVenta = reder.GetInt32(7);

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


        private void SetearTallas()
        {
            try
            {
                Tallas = new List<TallaModelInfo>();
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
                                info.DescripcionTalla = reder.GetString(1);
                                Tallas.Add(info);
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


        private void SetearCategorias()
        {
            try
            {
                Categorias = new List<CategoriaModelInfo>();
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
                                info.DescripcionCategoria = reder.GetString(1);
                                Categorias.Add(info);
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

        public class ArticuloModelInfo
        {
            public string DescripcionArticulo;
            public string EstadoArticulo;
            public int IdArticulo;
            public int IdBodega;
            public int IdCategoria;
            public int IdTalla;
            public string NombreArticulo;
            public int PrecioVenta;
        }

        public class TallaModelInfo
        {
            public string DescripcionTalla;
            public int IdTalla;
        }

        public class CategoriaModelInfo
        {
            public string DescripcionCategoria;
            public int IdCategoria;
        }
    }
}