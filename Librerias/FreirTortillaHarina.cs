using Librerias.Interfaces;
using System;

namespace Librerias
{
    public class FreirTortillaHarina : IFreir
    {
        /// <summary>
        /// Realiza la freidura del producto de harina
        /// </summary>
        /// <param name="Icantidad"></param>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="iTemperaturaFreidora">Entero con el valor de temperatura de la freidora</param>
        /// <returns>Tiempo de freído</returns>
        public TimeSpan Freir(byte Icantidad, byte TemperaturaFreidora)
        {
            return TimeSpan.FromSeconds((Icantidad * 900) / TemperaturaFreidora);
        }
    }
}
