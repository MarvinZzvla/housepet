using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIOS
{
    public class CatTalla
    {
        // private string TableName = "CAT_TALLA";
        private string TableName = "CRUD_CAT_TALLA";
        public string Parametro { get; set; }   
        public int IdTalla { get; set; }

        public string DescipcionTalla { get; set; }
        public string EstadoTalla { get; set; }

        //
        public Object Save(CatTalla Inst)
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
        public object GetTalla(CatTalla Inst)
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
