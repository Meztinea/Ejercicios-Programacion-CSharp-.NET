

namespace CandidatosPrestamo
{
    /// <summary>
    /// Excepción para validar el número de teléfnono de un solicitante
    /// </summary>
    public class NumeroTelException : ApplicationException
    {
        public NumeroTelException() : base("Error en el número de teléfono.")
        {
        }

        public NumeroTelException(string mensaje) : base(mensaje)
        {
        }

        public NumeroTelException(String mensaje, Exception excepcionAnidada) : base(mensaje, excepcionAnidada)
        {
            Console.WriteLine(excepcionAnidada.Message);
        }

        /// <summary>
        /// Método para validar el número de teléfono de un solicitante 
        /// </summary>
        /// <param name="NumeroTelefono"> Número de teléfono para validar </param>
        /// <exception cref="NumeroTelException"></exception>
        /// <exception cref="FormatException"></exception>
        public static void ValidarNumeroTelefono(String NumeroTelefono)
        {
            foreach (char caracter in NumeroTelefono)
            {
                if (char.IsLetter(caracter))
                {
                    // Número de teléfono que tiene letras
                    throw new NumeroTelException("El número de teléfono no debe contener letras.", new FormatException());
                }

                if (NumeroTelefono.Contains("-"))
                {
                    // Número de teléfono que contiene guión
                    throw new NumeroTelException("El número de teléfono no debe contener guiones.");                
                }
            }
        }

    }
}
