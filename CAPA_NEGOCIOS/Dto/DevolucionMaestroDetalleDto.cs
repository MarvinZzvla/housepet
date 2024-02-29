using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS.Dto
{
    public class DevolucionMaestroDetalleDto
    {
        public CabDevolucion cabecera { get; set; }
        public ICollection<DetDevolucion> detalle { get; set; }
    }
}
