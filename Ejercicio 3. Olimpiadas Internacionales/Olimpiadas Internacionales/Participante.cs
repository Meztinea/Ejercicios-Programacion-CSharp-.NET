
namespace OlimpiadasInternacionales
{
    /// <summary>
    /// Clase para crear objetos de tipo Participante
    /// </summary>
    internal class Participante
    {
        /// <summary>
        /// Atributos privados de la clase participante
        /// </summary>
        private String nombreYApellido;
        private int noParticipante;
        private String paisNatal;
        private int edad;
        private String continente;
        private Competencia competencia;

        /// <summary>
        /// Métodos constructores, setters y getters de la clase
        /// </summary>
        public Participante ()
        {

        }

        public void SetNombreYApellido(String nombreYApellido)
        {
            this.nombreYApellido = nombreYApellido;
        }

        public String GetNombreYApellido()
        {
            return this.nombreYApellido;
        }

        public void SetNoParticipante (int noParticipante)
        {
            this.noParticipante = noParticipante;
        }

        public void SetPaisNatal(String paisNatal)
        {
            this.paisNatal = paisNatal;
        }

        public String GetPaisNatal()
        {
            return this.paisNatal;
        }

        public void SetEdad (int edad)
        {
            this.edad = edad;
        }

        public void SetContinente (String continente)
        {
            this.continente = continente;
        }

        public void SetCompetencia (String nombreCompetencia, double distancia)
        {
            this.competencia = new Competencia(nombreCompetencia, distancia);
        }

        public Competencia GetCompetencia()
        {
            return this.competencia;
        }

    }
}
