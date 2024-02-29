using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CAPA_UI.Pages.MaestrosDetalles.Devoluciones
{
    public class DevolucionesIndexModel : PageModel
    {
        public string _Cnn;
        public DevolucionesIndexModel(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }
        public List<DevolucionModelInfo> listInfor = new List<DevolucionModelInfo>();

        public class DevolucionModelInfo
        {
            public string Parametro;
            public int IdCabDevolucion;
            public string NameArticulo;
            public DateTime FechaDevolucion;
            public int CodigoReferencia;
            public string NotaDevolucion;
        }

        public void OnGet()
        {
            try
            {
                string connectionString = _Cnn;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT cD.ID_CABECERA_DEVOLUCION,art.NOMBRE_CAT_ARTICULO,cD.FECHA_DEVOLUCION, cD.CODIGO_REFERENCIA,cD.NOTA FROM CABECERA_DEVOLUCION cD INNER JOIN DETALLE_DEVOLUCION dt ON cD.ID_CABECERA_DEVOLUCION = dt.FK_CABECERA_DEVOLUCION INNER JOIN CAT_ARTICULO art ON dt.FK_CAT_ARTICULO = art.ID_CAT_ARTICULO";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reder = command.ExecuteReader())
                        {
                            while (reder.Read())
                            {
                                DevolucionModelInfo info = new DevolucionModelInfo();
                                info.IdCabDevolucion = reder.GetInt32(0);
                                info.NameArticulo = reder.GetString(1);
                                info.FechaDevolucion = reder.GetDateTime(2);
                                info.CodigoReferencia = reder.GetInt32(3);
                                info.NotaDevolucion = reder.GetString(4);
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
