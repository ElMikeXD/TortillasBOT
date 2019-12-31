using System;

namespace Librerias
{
    public class ConvertidorTiempo : IConvertidorTiempo
    {
        /// <summary>
        /// Convierte el tiempo a horas, minutos y segundos
        /// </summary>
        /// <param name="dtTiempoPreparacion">Tiempo de preparación</param>
        /// <returns>Cadena con el formato de  tiempo requerido</returns>
        public string ObtenerTiempoPreparación(TimeSpan dtTiempoPreparacion)
        {
            string cTiempoPreparacion = dtTiempoPreparacion.Days + " Días " + dtTiempoPreparacion.Hours + " Horas " + dtTiempoPreparacion.Minutes + " Minutos y " + dtTiempoPreparacion.Seconds + " Segundos";

            return cTiempoPreparacion;
        }
    }
}
