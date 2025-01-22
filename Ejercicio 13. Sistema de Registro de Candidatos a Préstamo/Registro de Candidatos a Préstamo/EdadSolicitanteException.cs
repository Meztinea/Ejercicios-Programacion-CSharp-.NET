

namespace CandidatosPrestamo
{
    /// <summary>
    /// Excepción para controlar errores encontrados en la edad del solicitante
    /// </summary>
    public class EdadSolicitanteException : ApplicationException
    {
        public EdadSolicitanteException() : base("Error en la edad del solicitante.")
        {
        }

        public EdadSolicitanteException(string mensaje) : base(mensaje)
        {
        }

        public EdadSolicitanteException(String mensaje, Exception excepcionAnidada) : base(mensaje, excepcionAnidada)
        {
            Console.WriteLine(excepcionAnidada.Message);
        }

        /// <summary>
        /// Método que valida la edad del solicitante 
        /// </summary>
        /// <param name="Edad"> Edad para validar </param>
        /// <param name="sl"> Solicitante al que se le valida la edad </param>
        /// <exception cref="EdadSolicitanteException"></exception>
        public static void ValidarEdadSolicitante(int Edad, Solicitante sl)
        {
            // Edad por debajo del rango
            if (Edad < 18)
            {
                throw new EdadSolicitanteException("El solicitante no cuenta con la edad mínima para solicitar préstamo.");
            }
            // Edad por encima del rango
            else if (Edad > 64)
            {
                sl.SetEdad(Edad);
                throw new EdadSolicitanteException("La edad está fuera del rango superior, siga las instrucciones.");
            }
        }

    }
}
