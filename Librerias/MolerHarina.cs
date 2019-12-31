using Librerias.Interfaces;
using System;

namespace Librerias
{
    public class MolerHarina : IMoler
    {
        /// <summary>
        /// Realiza el molido del producto de Harina
        /// </summary>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="iVelocidadMoledor">Entero con el valor de temperatura del moledor</param>
        /// <returns>Tiempo de molido</returns>
        public TimeSpan Moler(byte iCantidad, byte iVelocidadMoledor)
        {
            return TimeSpan.FromSeconds((iCantidad * 60)/iVelocidadMoledor);
        }
    }
}
