using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class RefArticuloBodega
    {
        private string TableName = "CRUD_ARTICULO_BODEGA";
        public string Parametro { get; set; }
        public int Fk_Bodega { get; set; }
        public int Fk_Articulo { get; set; }
        public Decimal PrecioVentaArticulo { get; set; }
        public String EstadoArticuloBodega { get; set; }
      //  public String PesoArticulo = "0";
        public DateTime FechaVencArticuloBodega { get; set; }

        //
        public Object SaveArticuloBodega(RefArticuloBodega Inst)
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
        public Object GetArticuloBodega(RefArticuloBodega Inst)
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
