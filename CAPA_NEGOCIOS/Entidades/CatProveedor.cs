using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class CatProveedor
    {
        private string TableName = "CRUD_CAT_PROVEEDOR";
        public string Parametro { get; set; }
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public string CelularProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public string RucProveedor { get; set; }
        public string EstadoProveedor { get; set; }

        //
        public Object SaveProveedor(CatProveedor Inst)
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
        public Object GetProveedor(CatProveedor Inst)
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
