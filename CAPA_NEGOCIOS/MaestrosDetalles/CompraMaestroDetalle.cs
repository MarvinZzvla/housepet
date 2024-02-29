using CAPA_DATOS;
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
    public  class CompraMaestroDetalle: ICompraMaestroDetalle
    {
        public string _Cnn;
        public CompraMaestroDetalle(IConfiguration config) 
        {
            _Cnn = config.GetConnectionString("DbCon");
        }
        public bool Crear(CompraMaestroDetalleDto request)
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
                        stringcommand += "INSERT INTO CABECERA_COMPRA(FK_CAT_PROVEEDOR,FECHA_COMPRA,IVA_COMPRA,DESCUENTO_COMPRA,TOTAL_COMPRA) ";
                        stringcommand += $"values({request.cabecera.FKProveedor},'{currentDate}',{Decimal.Truncate(request.cabecera.IvaCompra)},{request.cabecera.DescuentoCompra},{request.cabecera.TotalCompra});";
                        Console.WriteLine(stringcommand);
                        cmd.CommandText = stringcommand;
                        cmd.ExecuteNonQuery();
                        
                        //obtengo el Id de la cabecera para la creacion de los detalles
                        //stringcommand = "select IDENT_CURRENT('CABECERA_COMPRA') as Id;";
                        stringcommand = "select Max(ID_CABECERA_COMPRA) as Id from CABECERA_COMPRA;";
                        cmd.CommandText = stringcommand;
                        SqlDataReader reader = cmd.ExecuteReader();

                        int CabeceraId=0;
                        //CabeceraId = Convert.ToInt32(reader.GetString(0));
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
                            stringcommand = "INSERT INTO DETALLE_COMPRA(FK_CABECERA_COMPRA,FK_CAT_ARTICULO,CANTIDAD_COMPRA,PRECIO_COMPRA) ";
                            stringcommand += $"values({CabeceraId},{linea.FkArticulo},{linea.CantidadCompra},{linea.PrecioCompra});";
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
