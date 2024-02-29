using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using static CAPA_UI.Pages.Inventario.InventarioIndexModel;
using System.Linq;

namespace CAPA_UI.Pages.Inventario
{
    public class EditModel : PageModel
    {
        public string _Cnn;
        public List<CategoriaModelInfo> Categorias;

        public List<ArticuloModelInfo> listInfor = new List<ArticuloModelInfo>();
        public List<InventarioModelInfo> listInventario = new List<InventarioModelInfo>();

        public List<TallaModelInfo> Tallas;

        public EditModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }

        public void OnGet()
        {
            AgregarUsuario();
            SetearTallas();
            SetearCategorias();
            ListarInventario();
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

            Console.WriteLine(listInfor);
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

        private void ListarInventario()
        {
            try
            {
                var connectionString = _Cnn;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var sql = "SELECT ID_CAT_ARTICULO,NOMBRE_CAT_ARTICULO, (SELECT SUM(CANTIDAD_COMPRA) FROM DETALLE_COMPRA WHERE FK_CAT_ARTICULO=ID_CAT_ARTICULO) as Compras, ISNULL((SELECT SUM(v.CANTIDAD_VENTA) from DETALLE_VENTA v WHERE v.FK_CAT_ARTICULO = ID_CAT_ARTICULO),0) as Ventas FROM CAT_ARTICULO as art INNER JOIN CAT_CATEGORIA as cat ON (art.FK_CAT_CATEGORIA = cat.ID_CAT_CATEGORIA) INNER JOIN CAT_TALLA AS talla ON (art.FK_CAT_TALLA = talla.ID_CAT_TALLA) FULL OUTER JOIN DETALLE_COMPRA dtCompra ON art.ID_CAT_ARTICULO = dtCompra.FK_CAT_ARTICULO LEFT JOIN CABECERA_COMPRA CA_COMPRA ON CA_COMPRA.ID_CABECERA_COMPRA = dtCompra.FK_CABECERA_COMPRA ORDER BY NOMBRE_CAT_ARTICULO";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new InventarioModelInfo();
                                info.IdArticulo = reder.GetInt32(0);
                                info.NombreArticulo = reder.GetString(1);
                                info.Compras = reder.GetInt32(2);
                                info.Ventas = reder.GetInt32(3);
                                listInventario.Add(info);
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


            listInventario = Enumerable.Reverse(listInventario).ToList();
            List<InventarioModelInfo> tmpList = new List<InventarioModelInfo>();
            tmpList.Add(listInventario.ElementAt(0));

            foreach (var element in listInventario)
            {
                bool isDuplicate = false;
                foreach (var tmp in tmpList.ToList())
                {
                    if (element.NombreArticulo == tmp.NombreArticulo)
                    {
                        isDuplicate = true;
                    }
                }

                if (!isDuplicate)
                {
                    tmpList.Add(element);
                }
            }
            listInventario = tmpList;

        }

        public class InventarioModelInfo
        {
            public int IdArticulo;
            public string NombreArticulo;
            public int Compras;
            public int Ventas;


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
