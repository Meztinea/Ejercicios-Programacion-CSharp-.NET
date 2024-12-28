namespace Matematicas
{
    using System;
    /// <summary>
    /// Clase que proporciona métodos para cálculos matemáticos.
    /// </summary>
    public class MathCalculator
    {
        /// <summary>
        /// Calcula el área de un círculo.
        /// </summary>
        /// <param name="radio">Radio del círculo.</param>
        /// <returns>El área del círculo.</returns>
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        /// <summary>
        /// Calcula la hipotenusa de un triángulo rectángulo.
        /// </summary>
        /// <param name="cateto1">Longitud del primer cateto.</param>
        /// <param name="cateto2">Longitud del segundo cateto.</param>
        /// <returns>La longitud de la hipotenusa.</returns>
        public static double CalcularHipotenusa(double cateto1, double cateto2)
        {
            return Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
        }
        /// <summary>
        /// Calcula la edad de una persona.
        /// </summary>
        /// <param name="anioNacimiento">Año de nacimiento de la persona.</param>
        /// <returns>La edad de la persona.</returns>
        public static int CalcularEdad(int anioNacimiento)
        {
            return DateTime.Now.Year - anioNacimiento;
        }
    }
}