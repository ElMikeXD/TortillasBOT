using Librerias.Interfaces;
using System;

namespace Librerias
{
    public class ElaborarTortilla : IPrepararProducto
    {
        /// <summary>
        /// Almacena la instancia del objeto para hornear
        /// </summary>
        private readonly IHornear oHornear;

        public ElaborarTortilla(IHornear Hornear)
        {
            this.oHornear = Hornear;
        }

        /// <summary>
        /// Realiza la preparación del producto
        /// </summary>
        /// <param name="iCantidad">Entero con la cantidad del ingrediente</param>
        /// <param name="iTemperaturaHorno">Entero con el valor de temperatura del Horno</param>
        /// <returns>Tiempo de Horneado</returns>
        public TimeSpan PrepararProducto(byte iCantidad, byte iTemperaturaHorno)
        {
            TimeSpan dtTiempoHorneado = oHornear.Hornear(iCantidad, iTemperaturaHorno);

            return dtTiempoHorneado;
        }
    }
}
