using Model.DTO;
using System;

namespace Librerias
{
    public class ProcesadorProductosDeMaiz : IProcesadorProducto
    {
        /// <summary>
        /// Realiza la elaboración de todos los productos de maíz
        /// </summary>
        /// <param name="oDatosElaboracionProducto">Objeto con los datos de elaboración</param>
        /// <returns>Tiempo total de la preparación</returns>
        public TimeSpan ElaborarProducto(DatosElaboracionProducto oDatosElaboracionProducto)
        {
            TimeSpan dtTiempoTotalPreparación = TimeSpan.Zero;

            IPrepararProducto elaborarMasa = new ElaborarMasa(new MolerMaiz());
            IPrepararProducto elaborarTortilla = new ElaborarTortilla(new HornearTortillaMaiz());
            IPrepararProducto elaborarTostada = new ElaborarTostada(new FreirTortillaMaiz());

            switch (oDatosElaboracionProducto.cProducto)
            {
                case "Masa":
                    dtTiempoTotalPreparación += elaborarMasa.PrepararProducto(oDatosElaboracionProducto.iCantidadProducto, oDatosElaboracionProducto.iVelocidadMoledor);
                    break;

                case "Tortillas":
                    dtTiempoTotalPreparación += elaborarTortilla.PrepararProducto(oDatosElaboracionProducto.iCantidadProducto, oDatosElaboracionProducto.iTemperaturaHorno);
                    goto case "Masa";

                case "Tostadas":
                    dtTiempoTotalPreparación += elaborarTostada.PrepararProducto(oDatosElaboracionProducto.iCantidadProducto, oDatosElaboracionProducto.iTemperaturaFreidora);
                    goto case "Tortillas";

                default:
                    break;
            }

            return dtTiempoTotalPreparación;
        }
    }
}

