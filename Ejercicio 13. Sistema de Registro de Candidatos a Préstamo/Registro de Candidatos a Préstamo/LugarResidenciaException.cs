
using System.Text.RegularExpressions;

namespace CandidatosPrestamo
{
    /// <summary>
    /// Excepción para controlar errores en el lugar de residencia del solicitante
    /// </summary>
    public class LugarResidenciaException : ApplicationException
    {
        public LugarResidenciaException() : base("El lugar de residencia no pertenece a la Ciudad de México.")
        {
        }

        public LugarResidenciaException(string mensaje) : base(mensaje)
        {
        }

        public LugarResidenciaException(String mensaje, Exception excepcionAnidada) : base(mensaje, excepcionAnidada)
        {
            Console.WriteLine(excepcionAnidada.Message);
        }

        /// <summary>
        /// Método que valida el lugar de residencia del solicitante 
        /// </summary>
        /// <param name="LugarResidencia"> Lugar de residencia para validar </param>
        /// <exception cref="LugarResidenciaException"></exception>
        public static void ValidarLugarResidencia(String LugarResidencia)
        {
            // Validando que la dirección sea de la Ciudad de México
            string patronRevision = @"\b(Ciudad de México|CDMX|México D\.?F\.?)\b";

            if (!Regex.IsMatch(LugarResidencia, patronRevision, RegexOptions.IgnoreCase)) {
                throw new LugarResidenciaException();
            }
        }

    }
}
