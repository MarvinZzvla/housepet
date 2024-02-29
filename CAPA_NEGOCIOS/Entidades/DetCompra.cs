using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class DetCompra
    {
        private string TableName = "CRUD_DETALLE_COMPRA";
        public string Parametro { get; set; }   
        public int FkCompra { get; set; }
        public int FkArticulo { get; set; }
        public int CantidadCompra { get; set; }
        public decimal PrecioCompra { get; set; }

        //
        public Object SaveDetCompra(DetCompra Inst)
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
        public Object GetDetCompra(DetCompra Inst)
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
