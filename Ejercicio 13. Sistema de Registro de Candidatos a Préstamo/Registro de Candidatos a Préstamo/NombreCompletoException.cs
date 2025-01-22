

namespace CandidatosPrestamo
{
    /// <summary>
    /// Excepcion para validar el nombre de un solicitante
    /// </summary>
    public class NombreCompletoException: ApplicationException 
    {

        public NombreCompletoException(): base("El nombre no debe contener números.")
        {
        }

        public NombreCompletoException(string mensaje) : base(mensaje)
        {
        }

        public NombreCompletoException(String mensaje, Exception excepcionAnidada) : base(mensaje, excepcionAnidada)
        {
        }

        /// <summary>
        /// Método para validar el nombre completo de un solicitante
        /// </summary>
        /// <param name="Nombre"> Nombre del solicitante que será validada </param>
        /// <exception cref="NombreCompletoException"></exception>
        public static void ValidarNombreCompleto(String Nombre)
        {
            foreach (char caracter in Nombre)
            {
                if (char.IsDigit(caracter))
                {
                    throw new NombreCompletoException(); // El nombre no es válido - se lanza la excepción
                }
            }
        }

    }
}
