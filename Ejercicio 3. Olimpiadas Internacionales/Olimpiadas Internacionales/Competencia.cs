
namespace OlimpiadasInternacionales
{
    /// <summary>
    /// Clase que permite crear objetos competencia
    /// </summary>
    internal class Competencia
    {
        /// <summary>
        /// Atributos de la clase competencia - privados
        /// </summary>
        private String nombreCompetencia;
        private double distancia;
        private double tiempo;
        private double velocidad;

        /// <summary>
        /// Métodos constructores, setters y getters de la clase 
        /// </summary>
        public Competencia() 
        {

        }

        public Competencia(string nombreCompetencia, double distancia)
        {
            this.nombreCompetencia = nombreCompetencia;
            this.distancia = distancia;
        }

        public void SetTiempo(double tiempo)
        {
            this.tiempo = tiempo;
        }

        public double GetTiempo()
        {
            return this.tiempo;
        }

        public double GetDistancia()
        {
            return this.distancia;
        }

        public void SetVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public double GetVelocidad()
        {
            return this.velocidad;
        }
    }
}
