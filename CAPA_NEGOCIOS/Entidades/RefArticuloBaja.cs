using System;
using CAPA_DATOS;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace CAPA_NEGOCIOS
{
    public class RefArticuloBaja
    {
        private string TableName = "CRUD_ARTICULO_BAJA";
        public string Parametro { get; set; }
        public int Id_Bodega { get; set; }  
        public int id_Articulo { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }
        public string Peso { get; set; }
        public DateTime Feccha { get; set; }


        //
        public Object SaveArticuloBaja(RefArticuloBaja Inst)
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
        public Object GetArticuloBaja(RefArticuloBaja Inst)
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
