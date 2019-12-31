using System;

namespace Librerias
{
    public interface IConvertidorTiempo
    {
        string ObtenerTiempoPreparación(TimeSpan dtTiempoPreparacion);
    }
}