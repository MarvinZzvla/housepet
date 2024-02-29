using System;

namespace CAPA_NEGOCIOS.Dto
{
    public class RptVentasDto
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}