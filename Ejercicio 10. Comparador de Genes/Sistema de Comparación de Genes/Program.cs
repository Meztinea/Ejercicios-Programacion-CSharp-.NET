
/// <summary>
/// Clase desde la que inicia el programa
/// </summary>
class Program
{
    /// <summary>
    /// Método principal desde el que inicia el programa
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Gen gen1 = new Gen();
        Gen gen2 = new Gen();


        // Creando el Gen principal
        Console.WriteLine("Ingresa los datos del Gen");
        Console.WriteLine("Nombre: ");
        gen1.Nombre = Console.ReadLine();
        Console.WriteLine("Ubicacion: ");
        gen1.Ubicacion = Console.ReadLine();
        Console.WriteLine("funcion: ");
        gen1.Funcion = Console.ReadLine();
        Console.WriteLine("secuencia: ");
        gen1.Secuencia = Console.ReadLine();


        while (true)
        {
            // Menú de opciones 
            Console.WriteLine("\n\nOpciones:");
            Console.WriteLine("1. Mostrar información del Gen");
            Console.WriteLine("2. Mutar secuencia del Gen");
            Console.WriteLine("3. Clonar el Gen");
            Console.WriteLine("4. Comparar dos Genes");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine(gen1.MostrarInformacion());
                    break;

                case "2":

                    Console.WriteLine("Ingresa la nueva Base: ");
                    char nuevaBase = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Ingresa la posicion: ");
                    int posicionBase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(gen1.MutarSecuencia(nuevaBase, posicionBase));
                    break;

                case "3":

                    gen2 = gen1.ClonarGen();
                    Console.WriteLine("Gen clonado exitosamente.");
                    break;

                case "4":

                    Console.WriteLine("Ingresa la secuencia del nuevo Gen: ");
                    String secuenciaNuevoGen = Console.ReadLine();
                    Gen nuevoGen = new Gen();
                    nuevoGen.Secuencia = secuenciaNuevoGen;
                    Console.WriteLine(gen1.CompararGenes(nuevoGen));
                    break;

                case "5":

                    Console.WriteLine("Saliendo del programa...");
                    return;

                default:

                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine();
        }
    }
}