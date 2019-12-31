using Model.DTO;
using System;

namespace Librerias
{
    public interface IProcesadorProducto
    {
        TimeSpan ElaborarProducto(DatosElaboracionProducto oDatosElaboracionProducto);
    }
}