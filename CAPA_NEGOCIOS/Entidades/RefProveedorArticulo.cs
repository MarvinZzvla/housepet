using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class RefProveedorArticulo
    {
        private string TableName = "CRUD_PROVEEDOR_ARTICULO";
        public string Parametro { get; set; }
        public int FkArticulo { get; set; }

        public int FkPoveedor { get; set; }
        public decimal PrecioCompra { get; set; }

        //
        public Object SaveProveedorArticulo(RefProveedorArticulo Inst)
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
        public Object GetProveedorArticulo(RefProveedorArticulo Inst)
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
