
using System.Text.RegularExpressions;

namespace CandidatosPrestamo
{
    /// <summary>
    /// Excepción para validar el correo electrónico de un solicitante
    /// </summary>
    public class CorreoElectronicoException : ApplicationException
    {
        public CorreoElectronicoException() : base("El correo electrónico debe contener arroba @.")
        {
        }

        public CorreoElectronicoException(string mensaje) : base(mensaje)
        {
        }

        public CorreoElectronicoException(String mensaje, Exception excepcionAnidada) : base(mensaje, excepcionAnidada)
        {
        }

        /// <summary>
        /// Método para validar el correo electrónico de un solicitante 
        /// </summary>
        /// <param name="CorreoElectronico"> Correo electrónico para validar </param>
        /// <exception cref="CorreoElectronicoException"></exception>
        public static void ValidarCorreoElectronico(String CorreoElectronico)
        {
            if (!CorreoElectronico.Contains("@"))
            {
                throw new CorreoElectronicoException(); // El correo no contiene un @ arroba se lanza la excepción básica
            }

            string patronDominioValido = @"@(gmail|outlook|yahoo|hotmail|icloud|hubspot)\.(com|net|org)$";

            if (!Regex.IsMatch(CorreoElectronico, patronDominioValido))
            {
                // El correo no contiene un dominio válido 
                throw new CorreoElectronicoException("El correo debe tener un dominio válido, por ejemplo, gmail, outlook, icloud, etc.");
            }
        }

    }
}
