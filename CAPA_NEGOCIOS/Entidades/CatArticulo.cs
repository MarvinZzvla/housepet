using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class CatArticulo
    {
        private string TableName = "CRUD_CAT_ARTICULO";
        public string Parametro { get; set; }
        public int IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public string EstadoArticulo { get; set; }
        public int IdCategoria { get; set; }
        public int IdTalla { get; set; }
        public int IdBodega { get; set; }
        public int PrecioVenta { get; set; }

        //
        public Object SaveArticulo(CatArticulo Inst)
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
        public Object GetArticulo(CatArticulo Inst)
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
