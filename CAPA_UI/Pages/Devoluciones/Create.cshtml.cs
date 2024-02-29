using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CAPA_UI.Pages.MaestrosDetalles.Devoluciones
{
    public class CreateModel : PageModel
    {
        public class ArticuloModelInfo
        {
            public int IdArticulo;
            public string NombreArticulo;
        }

        public class TipoDevolucionModelInfo
        {
            public int IdTipoDevolucion;
            public string Descripcion;
        }

        public List<ArticuloModelInfo> Articulos;
        public List<TipoDevolucionModelInfo> TipoDevoluciones;
        public string _Cnn;

        public CreateModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }

        public void OnGet()
        {
            SetearArticulos();
            SetearTipoDevolucion();
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

        private void SetearTipoDevolucion()
        {
            try
            {
                TipoDevoluciones = new List<TipoDevolucionModelInfo>();
                String connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM TIPO_DEVOLUCION";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                TipoDevolucionModelInfo info = new TipoDevolucionModelInfo();
                                info.IdTipoDevolucion = reder.GetInt32(0);
                                info.Descripcion = reder.GetString(1);
                                TipoDevoluciones.Add(info);
                            }
                        }
                        if (TipoDevoluciones.Count == 0)
                        {
                            sql = "Insert into TIPO_DEVOLUCION(DESCRIPCION) VALUES('Mal estado');";
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                            TipoDevolucionModelInfo info = new TipoDevolucionModelInfo();
                            info.IdTipoDevolucion = 1;
                            info.Descripcion = "Mal estado";
                            TipoDevoluciones.Add(info);
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
