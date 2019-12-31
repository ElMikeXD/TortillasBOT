using Librerias.Interfaces;
using System;

namespace Librerias 
{ 
    public class ElaborarMasa : IPrepararProducto
    {
        /// <summary>
        /// Propiedad que almacena la instancia del objeto para moler
        /// </summary>
        private readonly IMoler oMoler;

        public ElaborarMasa(IMoler Moler)
        {
            this.oMoler = Moler;
        }

        /// <summary>
        /// Realiza la preparación del producto
        /// </summary>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="iVelocidadMoledor">Entero con el valor de velocidad del moledor</param>
        /// <returns>Tiempo de Molido</returns>
        public TimeSpan PrepararProducto(byte iCantidad, byte iVelocidadMoledor)
        {
            TimeSpan dtMolerTiempo = oMoler.Moler(iCantidad, iVelocidadMoledor);

            return dtMolerTiempo;
        }
    }
}
