using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_UI.Pages.MaestrosDetalles.Ventas
{
    public class VentasIndexModel : PageModel
    {
        public string _Cnn;
        public VentasIndexModel(IConfiguration config)
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
        }

        public void OnGet()
        {

            try
            {
                string connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM CABECERA_VENTA";
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
