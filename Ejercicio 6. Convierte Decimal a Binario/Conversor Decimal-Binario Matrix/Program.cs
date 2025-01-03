namespace DecimalABinario
{
    /// <summary>
    /// Clase principal del programa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal del programa desde donde comienza a ejecutarse 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("Conversor de Sistema Decimal al Sistema Binario");
                Console.Write("Digita un número o presiona 'S' para salir: ");

                String opcion = Console.ReadLine();
                Console.WriteLine("");

                if (opcion.Equals("S") || opcion.Equals("s"))
                {
                    Console.WriteLine("Saliste del programa");
                    salir = true;
                }
                else
                {
                    String binario = convertirABinario(int.Parse(opcion));
                    Console.WriteLine("El número " + opcion + ", en binario es: " + binario + "\n");
                    imprimirEnBinario(binario);
                }

            } while (!salir);

        }

        /// <summary>
        /// Método que permite imprimir el número binario (ya convertido) 
        /// </summary>
        /// <param name="numero"> Dato de tipo String que almacena al número binario que se quiere imprimir </param>
        public static void imprimirEnBinario(String numero)
        {
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] == '1') // Imprimir uno
                {
                    imprimirUno();
                }
                else // Si no es uno, debe ser cero
                {
                    imprimirCero(); 
                }
            }
        }

        /// <summary>
        /// Método que permite convertir un número del sistema decimal a su representación en sistema binario
        /// </summary>
        /// <param name="numero"> Número del sistema decimal que se quiere convertir al sistema binario </param>
        /// <returns> Dato de tipo String que representa al número en sistema binario </returns>
        public static String convertirABinario(int numero)
        {
            String binario = "";
            int cociente = 1; 

            do
            {
                cociente = numero / 2;
                int residuo = numero % 2;  // Elemento que se recupera para formar el dato en binario

                numero = cociente;

                binario = residuo + binario;

            } while (cociente != 0);

            return binario;

        }

        /// <summary>
        /// Método que permite imprimir el número 1 en pantalla utilizando el símbolo "%"
        /// </summary>
        public static void imprimirUno()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("%");
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// Método que permite imprimir el número 0 en pantalla utilizando el símbolo "%"
        /// </summary>
        public static void imprimirCero()
        {
            Console.WriteLine("%%%%");

            for (int j = 0;j < 3; j++)
            {
                Console.WriteLine("%  %");
            }

            Console.WriteLine("%%%%");
            Console.WriteLine("");
        }
    }
}
