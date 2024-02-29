using CAPA_NEGOCIOS.Dto;
using CAPA_NEGOCIOS.InterfacesMaestrosDetalles;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace CAPA_NEGOCIOS
{
    public class VentaMaestroDetalle: IVentaMaestroDetalle
    {
        public string _Cnn;
        public VentaMaestroDetalle(IConfiguration config)
        {
            _Cnn = config.GetConnectionString("DbCon");
        }
        public bool Crear(VentaMaestroDetalleDto request)
        {
            try
            {
                using (TransactionScope Transaccion = new TransactionScope())
                {
                    using (SqlConnection Conneccion = new SqlConnection(_Cnn))
                    {
                        Conneccion.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Conneccion;

                        //Creo la cabecera en la transaccion
                        string stringcommand = "";
                        var currentDate = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss");
                        stringcommand += "INSERT INTO CABECERA_VENTA(NOMBRE_CLIENTE,FECHA_VENTA,IVA_VENTA,DESCUENTO_VENTA,TOTAL) ";
                        stringcommand += $"values('{request.cabecera.NombreCliente}','{currentDate}',{Decimal.Truncate(request.cabecera.IvaVenta)}";
                        stringcommand += $",{request.cabecera.DescuentoVenta},{request.cabecera.TotalVenta});";
                        cmd.CommandText = stringcommand;
                        cmd.ExecuteNonQuery();

                        //obtengo el Id de la cabecera para la creacion de los detalles
                        stringcommand = "select Max(ID_CABECERA_VENTA) as Id from CABECERA_VENTA;";
                        cmd.CommandText = stringcommand;
                        SqlDataReader reader = cmd.ExecuteReader();

                        int CabeceraId = 0;
                        if (!reader.HasRows)
                            throw new Exception();
                        while (reader.Read())
                        {
                            CabeceraId = reader.GetInt32(0);
                        }
                        if (CabeceraId == 0)
                            throw new Exception();
                        reader.Close();
                        //Por cada item en el detalle voy ejecutando el comando
                        foreach (var linea in request.detalle)
                        {
                            stringcommand = "INSERT INTO DETALLE_VENTA(FK_CABECERA_VENTA,FK_CAT_ARTICULO,CANTIDAD_VENTA,PRECIO_VENTA) ";
                            stringcommand += $"values({CabeceraId},{linea.FkArticulo},{linea.CantidadVenta},{linea.PrecioVenta});";
                            cmd.CommandText = stringcommand;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Transaccion.Complete();
                }
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
    }
}
