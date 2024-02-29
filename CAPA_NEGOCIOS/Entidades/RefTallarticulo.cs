using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class RefTallaArticulo
    {
        private string TableName = "CRUD_TLLA_ARTICULO";
        public string Parametro { get; set; }
        public int FkArticulo { get; set; }
        public int FkTalla { get; set; }
        public string DescipcionTallaArticulo { get; set; }

        //
        public Object SaveTallaArticulo(RefTallaArticulo Inst)
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
        public Object GetTallaArticulo(RefTallaArticulo Inst)
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
