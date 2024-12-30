
namespace RendimientoDispositivosMoviles
{
    /// <summary>
    /// Clase para crear evaluaciones 
    /// </summary>
    internal class Evaluacion
    {
        /// <summary>
        /// Atributos privados de la clase evaluación - describen las características de los objetos
        /// </summary>
        private double tamanioApps;
        private double tiempoAperturaApps;
        private double tamanioAlmacenamiento;
        private double promedioAppsAbiertas;
        private double tiempoProcesamientoMegabyte;
        private double almacenamientoEficiente;
        private double autonomiaEstimadaAplicacion;

        /// <summary>
        /// Método constructor de evaluaciones sin parámetros
        /// </summary>
        public Evaluacion()
        {

        }
        /// <summary>
        /// Métodos setters y getters para guardar y recuperar datos de los objetos
        /// </summary>
        public void SetAutonomiaEstimadaAplicacion(double autonomiaEstimadaAplicacion)
        {
            this.autonomiaEstimadaAplicacion = autonomiaEstimadaAplicacion;
        }

        public double GetAutonomiaEstimadaAplicacion()
        {
            return this.autonomiaEstimadaAplicacion;
        }

        public void SetAlmacenamientoEficiente(double almacenamientoEficiente)
        {
            this.almacenamientoEficiente = almacenamientoEficiente;
        }

        public double GetAlmacenamientoEficiente()
        {
            return this.almacenamientoEficiente;
        }

        public void SetTiempoProcesamientoMegabyte(double tiempoProcesamientoMegabyte)
        {
            this.tiempoProcesamientoMegabyte = tiempoProcesamientoMegabyte;
        }

        public double GetTiempoProcesamientoMegabyte()
        {
            return this.tiempoProcesamientoMegabyte;
        }

        public void SetPromedioAppsAbiertas(double promedioAppsAbiertas)
        {
            this.promedioAppsAbiertas = promedioAppsAbiertas;
        }

        public double GetpromedioAppsAbiertas()
        {
            return this.promedioAppsAbiertas;
        }

        public void SetTamanioAlmacenamiento(double tamanioAlmacenamiento)
        {
            this.tamanioAlmacenamiento = tamanioAlmacenamiento;
        }

        public double GetTamanioAlmacenamiento()
        {
            return this.tamanioAlmacenamiento;
        }

        public void SetTiempoAperturaApps(double tiempoAperturaApps)
        {
            this.tiempoAperturaApps = tiempoAperturaApps;
        }

        public double GetTiempoAperturaApps()
        {
            return this.tiempoAperturaApps;
        }

        public void SetTamanioApps(double tamanioApps)
        {
            this.tamanioApps = tamanioApps;
        }

        public double GetTamanioApps()
        {
            return this.tamanioApps;
        }

    }
}
