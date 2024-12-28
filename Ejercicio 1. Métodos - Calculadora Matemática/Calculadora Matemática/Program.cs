using Matematicas;

namespace CalculadoraMatematica
{
    /// <summary>
    /// Clase principal desde donde arranca el programa.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal del sistema.
        /// </summary>
        static void Main(string[] args)
        {
            // Calcula el área de un círculo con datos ingresados por el usuario 
            Console.WriteLine("Ingresa el radio del círculo en centímetros: ");
            double radio = double.Parse(Console.ReadLine());
            double areaCirculo = MathCalculator.CalcularAreaCirculo(radio); // llama al método estático
            Console.WriteLine($"El área del circulo es: {areaCirculo} cm\n\n");

            // Calcula la hipotenusa de un triangulo con datos ingresados por el usuario
            Console.WriteLine("Ingresa el primer cateto del triángulo en centímetros: ");
            double cateto1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo cateto del triángulo en centímetros: ");
            double cateto2 = double.Parse(Console.ReadLine());
            double hipotenusa = MathCalculator.CalcularHipotenusa(cateto1, cateto2); // llama al método estático
            Console.WriteLine($"La hipotenusa del triángulo es: {hipotenusa} cm\n\n");

            // Calcula la edad de una persona con datos ingresados por el usuario 
            Console.WriteLine("Ingresa el año de tu nacimiento: ");
            int anioNacimiento = int.Parse(Console.ReadLine());
            int edad = MathCalculator.CalcularEdad(anioNacimiento); // Llama al método estático
            Console.WriteLine($"Este año tendrás: {edad} años\n");
        }
    }
}
