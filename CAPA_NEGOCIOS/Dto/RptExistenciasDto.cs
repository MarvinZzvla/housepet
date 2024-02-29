using System;

namespace CAPA_NEGOCIOS.Dto
{
    public class RptExistenciasDto
    {
        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Proveedor { get; set; }
        public string UnidadMedida { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Existencias { get; set; }
    }
}