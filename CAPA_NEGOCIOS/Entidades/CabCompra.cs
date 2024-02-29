using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS
{
    public class CabCompra
    {
        private string TableName = "CRUD_CABECERA_COMPRA";
        public string Parametro { get; set; }   
        public int IdCabCompra { get; set; }
        public int FKProveedor { get; set; }
        public string FechaCompra { get; set; }
        public decimal IvaCompra { get; set; }
        public decimal DescuentoCompra { get; set; }
        public decimal TotalCompra { get; set; }

        public Object SaveCabCompra(CabCompra Inst)
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

        public Object GetCabCompra(CabCompra Inst)
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
