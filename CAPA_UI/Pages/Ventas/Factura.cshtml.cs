using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;


namespace CAPA_UI.Pages.Ventas
{
    public class FacturaModel : PageModel
    {

        public string _Cnn;
        public FacturaModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }
        public List<VentaModelInfo> listInfor = new List<VentaModelInfo>();

        public class VentaModelInfo
        {
            public int IdCabVenta;
            public string NombreCliente;
            public DateTime FechaVenta;
            public decimal IvaVenta;
            public decimal DescuentoVenta;
            public decimal TotalVenta;
            public string NombreArticulo;
        }

        public void OnGet()
        {
            try
            {
                string connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT caVenta.ID_CABECERA_VENTA, caVenta.NOMBRE_CLIENTE,caVenta.FECHA_VENTA, caVenta.IVA_VENTA,caVenta.DESCUENTO_VENTA, caVenta.TOTAL, caArt.NOMBRE_CAT_ARTICULO FROM CABECERA_VENTA caVenta INNER JOIN DETALLE_VENTA dtVenta ON ID_CABECERA_VENTA = FK_CABECERA_VENTA INNER JOIN CAT_ARTICULO caArt ON dtVenta.FK_CAT_ARTICULO = caArt.ID_CAT_ARTICULO";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                VentaModelInfo info = new VentaModelInfo();
                                info.IdCabVenta = reder.GetInt32(0);
                                info.NombreCliente = reder.GetString(1);
                                info.FechaVenta = reder.GetDateTime(2);
                                info.IvaVenta = reder.GetDecimal(3);
                                info.DescuentoVenta = reder.GetDecimal(4);
                                info.TotalVenta = reder.GetDecimal(5);
                                info.NombreArticulo= reder.GetString(6);
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
    }
}
