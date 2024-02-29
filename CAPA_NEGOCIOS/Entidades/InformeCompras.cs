using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using CAPA_NEGOCIOS.Dto;
using CAPA_NEGOCIOS.Helpers;

namespace CAPA_NEGOCIOS.Entidades
{
    public class InformeCompras
    {
        public List<String> Params { get; set; }
        
        public List<RptComprasDto> TakeInforme(InformeCompras Inst)
        {
            try
            {
                List<Object> SqlParams = new List<Object>();
                SqlParams.Add(Convert.ToDateTime(Inst.Params[0]));
                SqlParams.Add(Convert.ToDateTime(Inst.Params[1]));
                SqlADOCConexion.IniciarConexion();
                
                List<RptComprasDto> results = new List<RptComprasDto>();

                using (SqlConnection connection = new SqlConnection(ConstantsValues.ConnectionString))
                {
                    connection.Open();
                    var sdr = SqlADOCConexion.SQLM.TakeListWithProcedure(
                        "usp_informecompras", Inst, SqlParams,connection);
                    
                    while (sdr.Read())
                    {
                        results.Add(
                            new RptComprasDto()
                            {
                                Id  = sdr.GetInt32(0),
                                Proveedor = sdr.GetString(1),
                                FechaCompra = sdr.GetDateTime(2).Date,
                                Iva = sdr.GetDecimal(3),
                                Descuento = sdr.GetDecimal(4),
                                Total = sdr.GetDecimal(5)
                            }
                        );
                    }
                }
                return results;
            }
            catch(Exception exception)
            {
                throw;
            }
        }
        
        public List<RptVentasDto> TakeInformeVentas(InformeCompras Inst)
        {
            try
            {
                List<Object> SqlParams = new List<Object>();
                SqlParams.Add(Convert.ToDateTime(Inst.Params[0]));
                SqlParams.Add(Convert.ToDateTime(Inst.Params[1]));
                SqlADOCConexion.IniciarConexion();
                
                List<RptVentasDto> results = new List<RptVentasDto>();

                using (SqlConnection connection = new SqlConnection(ConstantsValues.ConnectionString))
                {
                    connection.Open();
                    var sdr = SqlADOCConexion.SQLM.TakeListWithProcedure(
                        "usp_informe_ventas", Inst, SqlParams,connection);
                    
                    while (sdr.Read())
                    {
                        results.Add(
                            new RptVentasDto()
                            {
                                Id  = sdr.GetInt32(0),
                                Cliente = sdr.GetString(1),
                                FechaCompra = sdr.GetDateTime(2).Date,
                                Iva = sdr.GetDecimal(3),
                                Descuento = sdr.GetDecimal(4),
                                Total = sdr.GetDecimal(5),
                                Articulo = sdr.GetString(6),
                                Cantidad = sdr.GetInt32(7),
                                PrecioVenta = sdr.GetDecimal(8)
                            }
                        );
                    }
                }
                return results;
            }
            catch(Exception exception)
            {
                throw;
            }
        }
        
        public List<RptExistenciasDto> TakeInformeExistencias(InformeCompras Inst)
        {
            try
            {
                List<Object> SqlParams = new List<Object>();
                SqlParams.Add(Convert.ToDateTime(Inst.Params[0]));
                SqlParams.Add(Convert.ToDateTime(Inst.Params[1]));
                SqlADOCConexion.IniciarConexion();
                
                List<RptExistenciasDto> results = new List<RptExistenciasDto>();

                using (SqlConnection connection = new SqlConnection(ConstantsValues.ConnectionString))
                {
                    connection.Open();
                    var sdr = SqlADOCConexion.SQLM.TakeListWithProcedure(
                        "usp_informe_existencias", Inst, SqlParams,connection);
                    
                    while (sdr.Read())
                    {
                        results.Add(
                            new RptExistenciasDto()
                            {
                                Id  = sdr.GetInt32(0),
                                Articulo = sdr.GetString(1),
                                Proveedor = sdr.GetString(2),
                                UnidadMedida = sdr.GetString(3),
                                FechaCompra = sdr.GetDateTime(4).Date,
                                PrecioCompra = sdr.GetDecimal(5),
                                Existencias = sdr.GetInt32(6)
                            }
                        );
                    }
                }
                return results;
            }
            catch(Exception exception)
            {
                throw;
            }
        }
    }
}
