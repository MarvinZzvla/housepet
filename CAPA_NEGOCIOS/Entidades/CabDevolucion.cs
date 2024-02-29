using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class CabDevolucion
    {


        private string TableName = "CRUD_CABECERA_DEVOLUCION";
        public string Parametro { get; set; }
        public int IdCabDevolucion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int IdTipoDevolucion { get; set; }
        public int CodigoReferencia { get; set; }
        public string NotaDevolucion { get; set; }

        //
        public Object SaveCabDevolucion(CabDevolucion Inst)
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
        public Object GetCabDevolucion(CabDevolucion Inst)
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
