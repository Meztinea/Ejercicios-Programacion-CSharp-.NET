

namespace CandidatosPrestamo
{
    /// <summary>
    /// Excepción para validar los ingresos de un solicitante
    /// </summary>
    public class IngresoSolicitanteException : ApplicationException
    {
        public IngresoSolicitanteException() : base("Los ingresos se encuentra fuera del rango permitido para ofrecer préstamo.")
        {
        }

        public IngresoSolicitanteException(string mensaje) : base(mensaje)
        {
        }

        public IngresoSolicitanteException(String mensaje, Exception excepcionAnidada) : base(mensaje, excepcionAnidada)
        {
            Console.WriteLine(excepcionAnidada.Message);
        }


        /// <summary>
        /// Método que valida si los ingresos se encuentran en el rago permitido para ofrecer préstamo
        /// </summary>
        /// <param name="Ingresos"> Argumento de tipo double que representa los ingresos del solicitante </param>
        /// <exception cref="IngresoSolicitanteException"> </exception>
        public static void ValidarIngresos(double Ingresos)
        {
            int SalarioMinimo = 250;
            // Salari por debajo del rango
            if (Ingresos < (SalarioMinimo * 2))
            {
                throw new IngresoSolicitanteException("El ingreso está por debajo de lo permitido");
            }
            // Salario por encima del rango
            else if (Ingresos > (SalarioMinimo * 5))
            {
                throw new IngresoSolicitanteException("El ingreso está por encima de lo permitido");
            }
        }

    }
}
