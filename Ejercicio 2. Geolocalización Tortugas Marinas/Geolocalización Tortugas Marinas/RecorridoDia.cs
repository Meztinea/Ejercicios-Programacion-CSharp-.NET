
namespace GeolocalizacionTortugasMarinas
{
    /// <summary>
    /// Clase de tipo Recorrido que contiene los datos para cada día de recorrido
    /// </summary>
    internal class RecorridoDia
    {
        private Coordenada coordenadaInicio;
        private Coordenada coordenadaFin;
        private double distanciaKm;
        private String direccion;
        private TimeSpan tiempoTranscurrido;
        private double velocidadPromedioNado;
        /// <summary>
        /// Método constructor sin parámetros
        /// </summary>
        public RecorridoDia() 
        {
        
        }
        /// <summary>
        /// Método constructor con dos parámetros
        /// </summary>
        /// <param name="coordenadaInicio">Objeto de tipo Coordenada que identifica el inicio de un recorrido</param>
        /// <param name="coordenadaFin">Objeto de tipo Coordenada que identifica el fin de un recorrido</param>
        public RecorridoDia(Coordenada coordenadaInicio, Coordenada coordenadaFin)
        {
            this.coordenadaInicio = coordenadaInicio;
            this.coordenadaFin = coordenadaFin;
        }
        /// <summary>
        /// Métodos setters y getters de todos los atributos de la clase 
        /// </summary>
        public void SetVelocidadPromedioNado(double velocidadPromedioNado)
        {
            this.velocidadPromedioNado = velocidadPromedioNado;
        }

        public double GetVelocidadPromedioNado()
        {
            return velocidadPromedioNado;
        }

        public void setTiempoTranscurrido(TimeSpan tiempoTranscurrido)
        {
            this.tiempoTranscurrido = tiempoTranscurrido;
        }

        public TimeSpan GetTiempoTranscurrido()
        {
            return this.tiempoTranscurrido; 
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String GetDireccion()
        {
            return this.direccion;
        }

        public void setDistanciaKM(double distancia)
        {
            this.distanciaKm = distancia;
        }

        public double GetDistanciaKM()
        {
            return this.distanciaKm;
        }

        public void SetCoordenadaInicio(Coordenada coordenada)
        {
            this.coordenadaInicio = coordenada;
        }

        public Coordenada GetCoordenadaInicio() 
        {
            return this.coordenadaInicio;
        }

        public void SetCoordenadaFin(Coordenada coordenada)
        {
            this.coordenadaFin = coordenada;
        }

        public Coordenada GetCoordenadaFin()
        {
            return this.coordenadaFin;
        }
    }
}
