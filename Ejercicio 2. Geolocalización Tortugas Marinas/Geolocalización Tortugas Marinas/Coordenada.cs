
namespace GeolocalizacionTortugasMarinas
{
    /// <summary>
    /// Clase de tipo Coordenada que permite almacenar los datos de una coordenada de inicio o fin
    /// </summary>
    internal class Coordenada
    {
        private double latitud;
        private double longitud;
        private DateTime fechaHora;
        /// <summary>
        /// Método constructor sin parámetros
        /// </summary>
        public Coordenada()
        {

        }
        /// <summary>
        /// Método constructor con tres parámetros
        /// </summary>
        /// <param name="latitud"></param>
        /// <param name="longitud"></param>
        /// <param name="fechaHora"></param>
        public Coordenada(double latitud, double longitud, DateTime fechaHora)
        {
            this.latitud = latitud;
            this.longitud = longitud;
            this.fechaHora = fechaHora;
        }
        /// <summary>
        /// Métodos setters y getters de todos los atributos de la clase
        /// </summary>
        public void SetLatitud(double latitud)
        {
            this.latitud = latitud;
        }

        public double GetLatitud() 
        {
            return this.latitud;
        }

        public void SetLongitud(double longitud)
        {
            this.longitud = longitud;
        }

        public double GetLongitud() 
        {
            return this.longitud;
        }

        public void SetFechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }

        public DateTime GetFechaHora()
        {
            return this.fechaHora;
        }
    }
}
