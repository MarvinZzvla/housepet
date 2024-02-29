using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS.Dto
{
    public class VentaMaestroDetalleDto
    {
        public CabVenta cabecera { get; set; }
        public ICollection<DetVenta> detalle { get; set; }
    }
}
