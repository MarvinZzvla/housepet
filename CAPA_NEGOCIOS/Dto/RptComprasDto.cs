using System;

namespace CAPA_NEGOCIOS.Dto
{
    public class RptComprasDto
    {
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
    }
}