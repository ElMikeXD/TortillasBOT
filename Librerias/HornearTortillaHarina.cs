using Librerias.Interfaces;
using System;

namespace Librerias
{
    public class HornearTortillaHarina : IHornear
    {
        /// <summary>
        /// Realiza el horneado del producto de harina
        /// </summary>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="TemperaturaHorno">Entero con el valor de temperatura del horno</param>
        /// <returns>Tiempo de horneado</returns>
        public TimeSpan Hornear(byte Icantidad, byte TemperaturaHorno)
        {
            return TimeSpan.FromSeconds((Icantidad * 300)/TemperaturaHorno);
        }
    }
}
