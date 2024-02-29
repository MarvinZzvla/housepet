using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CAPA_UI.Pages.MaestrosDetalles.Ventas
{
    public class CreateModel : PageModel
    {
        public class ExistenciasModelInfo
        {
            public int id;
            public int cantidad;
        }

        public class ArticuloModelInfo
        {
            /*public int IdArticulo;
            public string NombreArticulo;
            public string DescripcionArticulo;
            public string EstadoArticulo;
            public int IdCategoria;*/
            public int IdArticulo;
            public string NombreArticulo;
            public string DescripcionArticulo;
            public string EstadoArticulo;
            public string Categoria;
            public string Talla;
            public string Bodega;
            public int PrecioVenta;
        }

        public List<ArticuloModelInfo> Articulos;
        public List<ExistenciasModelInfo> Existencias;
        public string _Cnn;

        public CreateModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }

        public void OnGet()
        {
            SetearArticulos();
            GetExistencias();
        }

        private void SetearArticulos()
        {
            try
            {
                Articulos = new List<ArticuloModelInfo>();
                String connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM VST_LISTADO_ARTICULOS";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                ArticuloModelInfo info = new ArticuloModelInfo();
                                info.IdArticulo = reder.GetInt32(0);
                                info.NombreArticulo = reder.GetString(1);
                                info.DescripcionArticulo = reder.GetString(2);
                                info.Categoria = reder.GetString(3);
                                info.Talla = reder.GetString(4);
                                info.Bodega = reder.GetString(5);
                                info.PrecioVenta = reder.GetInt32(6);
                                Articulos.Add(info);
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

        
        
        private void GetExistencias()
        {
            try
            {
                Existencias = new List<ExistenciasModelInfo>();
                String connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT compra.FK_CAT_ARTICULO, SUM(CANTIDAD_COMPRA) - ISNULL((SELECT SUM(CANTIDAD_VENTA) FROM DETALLE_VENTA venta WHERE compra.FK_CAT_ARTICULO = venta.FK_CAT_ARTICULO GROUP BY FK_CAT_ARTICULO),0) from DETALLE_COMPRA compra GROUP BY FK_CAT_ARTICULO";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                ExistenciasModelInfo info = new ExistenciasModelInfo();
                                info.id = reder.GetInt32(0);
                                info.cantidad = reder.GetInt32(1);
                                
                                Existencias.Add(info);
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
    }
}
