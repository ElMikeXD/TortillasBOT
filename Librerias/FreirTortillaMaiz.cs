using Librerias.Interfaces;
using System;

namespace Librerias
{
    public class FreirTortillaMaiz : IFreir
    {
        /// <summary>
        /// Realiza la freidura del producto de maíz
        /// </summary>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="iTemperaturaFreidora">Entero con el valor de temperatura de la freidora</param>
        /// <returns>Tiempo de freído</returns>
        public TimeSpan Freir(byte Icantidad, byte TemperaturaFreidora)
        {
            return TimeSpan.FromSeconds((Icantidad * 1200)/TemperaturaFreidora);
        }
    }
}
