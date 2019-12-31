using Librerias.Interfaces;
using System;

namespace Librerias
{
    public class ElaborarTostada : IPrepararProducto
    {
        private readonly IFreir oFreir;

        public ElaborarTostada(IFreir Freir)
        {
            this.oFreir = Freir;
        }

        /// <summary>
        /// Realiza la preparación del producto
        /// </summary>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="iTemperaturaFreidora">Entero con el valor de temperatura de la freidora</param>
        /// <returns>Tiempo de freído</returns>
        public TimeSpan PrepararProducto(byte iCantidad, byte iTemperaturaFreidora)
        {
            TimeSpan dtTiempoFreir = oFreir.Freir(iCantidad, iTemperaturaFreidora);

            return dtTiempoFreir;
        }
    }
} 
