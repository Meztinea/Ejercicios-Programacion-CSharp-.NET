
namespace RendimientoDispositivosMoviles
{
    /// <summary>
    /// Clase con métodos estáticos que devuelven datos
    /// </summary>
    internal class MetodosReturn
    {
        /// <summary>
        /// Método que calcula el TPB 
        /// </summary>
        /// <param name="tamanioApp"> Dato de tipo double que indica el tamaño de una aplicación</param>
        /// <param name="tiempoAperturaApp"> Dato de tipo double que indica el tiempo de apertura de una aplicación</param>
        /// <returns> Dato de tipo double que indica el TPB</returns>
        public static double calcularTPB(double tamanioApp, double tiempoAperturaApp)
        {
            return tiempoAperturaApp / tamanioApp;
        }

        /// <summary>
        /// Método que calcula el IE
        /// </summary>
        /// <param name="tiempoProcesamientoMegabyte"> Dato de tipo double que indica el tiempo de procesamiento por MB</param>
        /// <param name="tamanioAlmacenamiento"> Dato de tipo double que indica el tamaño de almacenamiento compartido</param>
        /// <returns> Dato de tipo double que indica el IE</returns>
        public static double calcularIE(double tiempoProcesamientoMegabyte, double tamanioAlmacenamiento)
        {
            return tiempoProcesamientoMegabyte * tamanioAlmacenamiento;
        }

        /// <summary>
        /// Método que calcula el AEA
        /// </summary>
        /// <param name="almacenamientoEficiente"> Dato de tipo double que indica el indice de almacenamiento eficiente</param>
        /// <param name="promedioAppsAbiertas"> Dato de tipo double que indica el promedio de aplicaciones abiertas</param>
        /// <returns> Dato de tipo double que indica el AEA</returns>
        public static double calcularAEA(double almacenamientoEficiente, double promedioAppsAbiertas)
        {
            return almacenamientoEficiente / promedioAppsAbiertas;
        }

    }
}
