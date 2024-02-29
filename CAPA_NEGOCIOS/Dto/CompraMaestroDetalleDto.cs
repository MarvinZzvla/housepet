using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS.Dto
{
    public class CompraMaestroDetalleDto
    {
        public CabCompra cabecera { get; set; }
        public ICollection<DetCompra> detalle { get; set; }
    }
}
