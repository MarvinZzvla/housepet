using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_UI.Pages.MaestrosDetalles.Compras
{
    public class ComprasIndexModel : PageModel
    {
        public string _Cnn;
        public ComprasIndexModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }
        
        public List<CompraModelInfo> listInfor = new List<CompraModelInfo>();

        public class CompraModelInfo
        {
            public int IdCabCompra;
            public int FKProveedor;
            public DateTime FechaCompra;
            public decimal IvaCompra;
            public decimal DescuentoCompra;
            public decimal TotalCompra;
            public string NombreProvedor;
        }

        public void OnGet()
        {
            try
            {
                string connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT CB.ID_CABECERA_COMPRA,CB.FK_CAT_PROVEEDOR,CB.FECHA_COMPRA, CB.IVA_COMPRA, CB.DESCUENTO_COMPRA,CB.TOTAL_COMPRA,PRO.NOMBRE_PROVEEDOR FROM CABECERA_COMPRA CB INNER JOIN CAT_PROVEEDOR PRO ON CB.FK_CAT_PROVEEDOR = PRO.ID_CAT_PROVEEDOR";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                CompraModelInfo info = new CompraModelInfo();
                                info.IdCabCompra = reder.GetInt32(0);
                                info.FKProveedor = reder.GetInt32(1);
                                info.FechaCompra = reder.GetDateTime(2);
                                info.IvaCompra = reder.GetDecimal(3);
                                info.DescuentoCompra = reder.GetDecimal(4);
                                info.TotalCompra = reder.GetDecimal(5);
                                info.NombreProvedor = reder.GetString(6);
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
