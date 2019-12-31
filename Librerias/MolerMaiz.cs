using Librerias.Interfaces;
using System;

namespace Librerias
{
    public class MolerMaiz : IMoler
    {
        /// <summary>
        /// Realiza el molido del producto de maíz
        /// </summary>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="iVelocidadMoledor">Entero con el valor de temperatura del moledor</param>
        /// <returns>Tiempo de molido</returns>
        public TimeSpan Moler(byte iCantidad, byte IvelocidadMoledor)
        {
            return TimeSpan.FromSeconds((iCantidad * 120)/IvelocidadMoledor);
        }
    }
}
