using CAPA_NEGOCIOS.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIOS.InterfacesMaestrosDetalles
{
    public interface IVentaMaestroDetalle
    {
        bool Crear(VentaMaestroDetalleDto request);
    }
}
