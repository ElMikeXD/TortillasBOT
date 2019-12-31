using System;

namespace Librerias
{
    public interface IPrepararProducto
    {
        TimeSpan PrepararProducto(byte iCantidad, byte NivelHerramienta);
    }
}