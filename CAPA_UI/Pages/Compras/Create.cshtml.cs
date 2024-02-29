using CAPA_NEGOCIOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CAPA_UI.Pages.MaestrosDetalles.Compras
{
    public class CreateCompraModel : PageModel
    {

        public class ArticuloModelInfo
        {
            public int IdArticulo;
            public string NombreArticulo;
            public string DescripcionArticulo;
            public string EstadoArticulo;
            public int IdCategoria;
            public int IdTalla;
            public int IdBodega;
            public int PrecioVenta;
        }
        public class ProveedorModelInfo
        {
            public int IdProveedor;
            public string NombreProveedor;
        }

        public List<ArticuloModelInfo> Articulos;
        public List<ProveedorModelInfo> Proveedores;
        public string _Cnn;

        public CreateCompraModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }

        public void OnGet()
        {
            SetearArticulos();
            SetearProveedores();
        }
        
        private void SetearProveedores()
        {
            try
            {
                Proveedores = new List<ProveedorModelInfo>();
                String connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM CAT_PROVEEDOR";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                ProveedorModelInfo info = new ProveedorModelInfo();
                                info.IdProveedor = reder.GetInt32(0);
                                info.NombreProveedor = reder.GetString(1);
                                Proveedores.Add(info);
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
        private void SetearArticulos() 
        {
            try
            {
                Articulos = new List<ArticuloModelInfo>();
                String connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM CAT_ARTICULO";
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
                                info.EstadoArticulo = reder.GetString(3);
                                info.IdCategoria = reder.GetInt32(4);
                                info.IdTalla = reder.GetInt32(5);
                                info.IdBodega= reder.GetInt32(6);
                                info.PrecioVenta = reder.GetInt32(7);
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
    }
}
