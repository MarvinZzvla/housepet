using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class CabVenta
    {
        private string TableName = "CRUD_CABECERA_VENTA";
        public string Parametro {get;set;}  
        public int IdCabVenta { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal IvaVenta { get; set; }
        public decimal DescuentoVenta { get; set; }
        public decimal TotalVenta { get; set; }


        //
        public Object SaveCabVenta(CabVenta Inst)
        {
            try
            {
                SqlADOCConexion.IniciarConexion();
                return SqlADOCConexion.SQLM.InsertObject(TableName, Inst);
            }
            catch
            {
                throw;
            }
        }

        //
        public Object GetCabVenta(CabVenta Inst)
        {
            try
            {
                SqlADOCConexion.IniciarConexion();
                return SqlADOCConexion.SQLM.TakeList(TableName, Inst, null);
            }
            catch
            {
                throw;
            }
        }
    }
}
