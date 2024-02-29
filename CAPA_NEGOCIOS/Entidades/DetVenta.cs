using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class DetVenta
    {
        private string TableName = "CRUD_DETALLE_VENTA";
        public string Parametro { get; set; }
        public int FkCabVenta { get; set; }
        public int FkArticulo { get; set; }

        public decimal CantidadVenta { get; set; }
        public decimal PrecioVenta { get; set; }

        //
        public Object SaveDetVenta(DetVenta Inst)
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
        public Object GetDetVenta(DetVenta Inst)
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
