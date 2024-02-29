using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class DetDevolucion
    {
        private string TableName = "CRUD_DETALLE_DEVOLCUION";
        public string Parametro { get; set; }
        public int FkDevolucion { get; set; }
        public int FkArticulo { get; set; }

        public int Cantidad { get; set; }
        public decimal Precio { get; set; }


        //
        public Object SaveDetDevolucion(DetDevolucion Inst)
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
        public Object GetDetDevolucion(DetDevolucion Inst)
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
