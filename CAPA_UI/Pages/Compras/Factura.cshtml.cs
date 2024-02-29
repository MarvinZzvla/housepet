using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;


namespace CAPA_UI.Pages.Compras
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
                    string sql = "SELECT caVenta.ID_CABECERA_COMPRA, caVenta.FECHA_COMPRA, caVenta.IVA_COMPRA,caVenta.DESCUENTO_COMPRA, caVenta.TOTAL_COMPRA, caArt.NOMBRE_CAT_ARTICULO FROM CABECERA_COMPRA caVenta INNER JOIN DETALLE_COMPRA dtVenta ON ID_CABECERA_COMPRA = FK_CABECERA_COMPRA INNER JOIN CAT_ARTICULO caArt ON dtVenta.FK_CAT_ARTICULO = caArt.ID_CAT_ARTICULO";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                VentaModelInfo info = new VentaModelInfo();
                                info.IdCabVenta = reder.GetInt32(0);
                                info.FechaVenta = reder.GetDateTime(1);
                                info.IvaVenta = reder.GetDecimal(2);
                                info.DescuentoVenta = reder.GetDecimal(3);
                                info.TotalVenta = reder.GetDecimal(4);
                                info.NombreArticulo= reder.GetString(5);
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
