using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class CatCategoria
    {
        private string TableName = "CRUD_CAT_CATEGORIA";
        public string Parametro { get; set; }   
        public int IdCategoria { get; set; }

        public string DescipcionCategoria { get; set; }
        public string EstadoCategoria { get; set; }

        //
        public Object SaveCategoria(CatCategoria Inst)
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
        public Object GetCategoria(CatCategoria Inst)
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
