using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static CAPA_UI.Pages.IndexModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using static CAPA_UI.Pages.MaestrosDetalles.Ventas.CreateModel;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System.Text.RegularExpressions;

namespace CAPA_UI.Pages.Inventario
{
    public class InventarioIndexModel : PageModel
    {

        public string _Cnn;
        public List<InventarioModelInfo> listInfor = new List<InventarioModelInfo>();
        public List<ExistenciasModelInfo> listExistencias;
        public class ExistenciasModelInfo
        {
            public int id;
            public int cantidad;
        }

        public void OnGet()
        {
            ListarInventario();
            GetExistencias();
        }

        public InventarioIndexModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }



        private void ListarInventario()
        {
            try
            {
                var connectionString = _Cnn;

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var sql = "SELECT ID_CAT_ARTICULO,NOMBRE_CAT_ARTICULO,DESCRIPCION_CAT_ARTICULO,ACTIVO_CAT_ARTICULO, cat.DESCRIPCION_CAT_CATEGORIA , talla.DESCRIPCION_CAT_TALLA, ISNULL(dtCompra.PRECIO_COMPRA,0) PRECIO_COMPRA, ISNULL(dtVenta.PRECIO_VENTA,0) PRECIO_VENTA, ISNULL(CA_COMPRA.FECHA_COMPRA,'2022/01/01')as Fecha_Compra, (SELECT SUM(CANTIDAD_COMPRA) - ISNULL((SELECT SUM(CANTIDAD_VENTA) FROM DETALLE_VENTA venta WHERE compra.FK_CAT_ARTICULO = venta.FK_CAT_ARTICULO GROUP BY FK_CAT_ARTICULO),0) from DETALLE_COMPRA compra WHERE compra.FK_CAT_ARTICULO = ID_CAT_ARTICULO GROUP BY FK_CAT_ARTICULO) as Existencias, ISNULL((SELECT SUM(((PRECIO_VENTA - PRECIO_COMPRA) * CANTIDAD_VENTA)) FROM DETALLE_VENTA ddVenta INNER JOIN DETALLE_COMPRA ddCompra ON ddVenta.FK_CAT_ARTICULO = ddCompra.FK_CAT_ARTICULO WHERE ddVenta.FK_CAT_ARTICULO = ID_CAT_ARTICULO GROUP BY ddVenta.FK_CAT_ARTICULO),0) as Utilidades FROM CAT_ARTICULO as art INNER JOIN CAT_CATEGORIA as cat ON (art.FK_CAT_CATEGORIA = cat.ID_CAT_CATEGORIA) INNER JOIN CAT_TALLA AS talla ON (art.FK_CAT_TALLA = talla.ID_CAT_TALLA) FULL OUTER JOIN DETALLE_COMPRA dtCompra ON art.ID_CAT_ARTICULO = dtCompra.FK_CAT_ARTICULO LEFT JOIN CABECERA_COMPRA CA_COMPRA ON CA_COMPRA.ID_CABECERA_COMPRA = dtCompra.FK_CABECERA_COMPRA LEFT JOIN DETALLE_VENTA dtVenta ON art.ID_CAT_ARTICULO = dtVenta.FK_CAT_ARTICULO ORDER BY NOMBRE_CAT_ARTICULO";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                var info = new InventarioModelInfo();
                                info.IdArticulo = reder.GetInt32(0);
                                info.NombreArticulo = reder.GetString(1);
                                info.DescripcionArticulo = reder.GetString(2);
                                info.EstadoArticulo = reder.GetString(3);
                                info.DescCategoria = reder.GetString(4);
                                info.DescTalla = reder.GetString(5);
                                info.PrecioCompra = (int)reder.GetDecimal(6);
                                info.PrecioVenta = (int)reder.GetDecimal(7);
                                info.FechaCompra = reder.GetDateTime(8);
                                info.Existencias = reder.GetInt32(9);
                                info.Utilidades= (int)reder.GetDecimal(10);
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

            try
            {
                listInfor = Enumerable.Reverse(listInfor).ToList();
                List<InventarioModelInfo> tmpList = new List<InventarioModelInfo>();
                tmpList.Add(listInfor.ElementAt(0));

                foreach (var element in listInfor)
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
                listInfor = tmpList;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
                
            
        }

        public class InventarioModelInfo
        {
            public int IdArticulo;
            public string NombreArticulo;
            public string DescripcionArticulo;
            public string EstadoArticulo;
            public string DescCategoria;
            public string DescTalla;
            public int PrecioCompra;
            public int PrecioVenta;
            public DateTime FechaCompra;
            public int Existencias;
            public int Utilidades;


        }


        private void GetExistencias()
        {
            try
            {
                listExistencias = new List<ExistenciasModelInfo>();
                String connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT ID_CAT_ARTICULO,NOMBRE_CAT_ARTICULO,DESCRIPCION_CAT_ARTICULO,ACTIVO_CAT_ARTICULO, cat.DESCRIPCION_CAT_CATEGORIA ,talla.DESCRIPCION_CAT_TALLA, ISNULL(dtCompra.PRECIO_COMPRA,0) PRECIO_COMPRA, ISNULL(CA_COMPRA.FECHA_COMPRA,'2022/01/01')as Fecha_Compra,(SELECT SUM(CANTIDAD_COMPRA) - ISNULL((SELECT SUM(CANTIDAD_VENTA) FROM DETALLE_VENTA venta WHERE compra.FK_CAT_ARTICULO = venta.FK_CAT_ARTICULO GROUP BY FK_CAT_ARTICULO),0) as Existencias from DETALLE_COMPRA compra WHERE compra.FK_CAT_ARTICULO = ID_CAT_ARTICULO GROUP BY FK_CAT_ARTICULO) FROM CAT_ARTICULO as art INNER JOIN CAT_CATEGORIA as cat ON (art.FK_CAT_CATEGORIA = cat.ID_CAT_CATEGORIA) INNER JOIN CAT_TALLA AS talla ON (art.FK_CAT_TALLA = talla.ID_CAT_TALLA) FULL OUTER JOIN DETALLE_COMPRA dtCompra ON art.ID_CAT_ARTICULO = dtCompra.FK_CAT_ARTICULO LEFT JOIN CABECERA_COMPRA CA_COMPRA ON CA_COMPRA.ID_CABECERA_COMPRA = dtCompra.FK_CABECERA_COMPRA ORDER BY NOMBRE_CAT_ARTICULO";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                ExistenciasModelInfo info = new ExistenciasModelInfo();
                                info.id = reder.GetInt32(0);
                                info.cantidad = reder.GetInt32(1);

                                listExistencias.Add(info);
                            }
                        }
                    }
                }

                listExistencias = Enumerable.Reverse(listExistencias).ToList();
                Console.WriteLine(listExistencias);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}
