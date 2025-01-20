

using CifradorMensajes;

/// <summary>
/// clase principal del programa 
/// </summary>
public class Program
{

    public static CifradoBasico CB;
    public static CifradoPorDesplazamiento CDZ;
    public static CifradoAES CA;
    public static CifradoDoble CD;

    /// <summary>
    /// Método principal - Aquí se ejecuta el sistema
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        String mensaje = "";
        bool salir = false;

        while (!salir)
        {
            //Console.Clear();
            Console.WriteLine("\n\n*** Sistema de Cifrado y Descifrado ***");
            Console.WriteLine("1. Cifrar Mensaje Básico");
            Console.WriteLine("2. Descifrar Mensaje Básico");
            Console.WriteLine("3. Cifrar Mensaje por Desplazamiento");
            Console.WriteLine("4. Descifrar Mensaje por Desplazamiento");
            Console.WriteLine("5. Cifrar Mensaje por AES");
            Console.WriteLine("6. Descifrar Mensaje por AES");
            Console.WriteLine("7. Cifrado Doble");
            Console.WriteLine("8. Descifrado Doble");
            Console.WriteLine("9. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    // Cifrar mensaje básico
                    Console.WriteLine("Ingresa el mensaje de texto: ");
                    mensaje = Console.ReadLine();

                    CB = new CifradoBasico(mensaje);
                    CB.Cifrar();
                    Console.WriteLine("El mensaje cifrado es: " + CB.GetMensajeOriginal());
                    break;
                case "2":
                    // Descifrar mensaje básico
                    Console.WriteLine("Ingresa el mensaje cifrado: ");
                    mensaje = Console.ReadLine();

                    CB = new CifradoBasico(mensaje);
                    CB.Descifrar();
                    Console.WriteLine("El mensaje descifrado es: " + CB.GetMensajeOriginal());
                    break;
                case "3":
                    // Cifrar mensaje por desplazamiento
                    Console.WriteLine("Ingresa el mensaje de texto: ");
                    mensaje = Console.ReadLine();
                    CDZ = new CifradoPorDesplazamiento(mensaje);

                    Console.WriteLine("Ingresa el desplazamiento (1-25): ");
                    CDZ.SetDesplazamiento(int.Parse(Console.ReadLine()));
                    CDZ.Cifrar();
                    Console.WriteLine("El mensaje cifrado es: " + CDZ.GetMensajeOriginal());
                    break;
                case "4":
                    // Descifrar mensaje por desplazamiento
                    Console.WriteLine("Ingresa el mensaje cifrado: ");
                    mensaje = Console.ReadLine();
                    CDZ = new CifradoPorDesplazamiento(mensaje);

                    Console.WriteLine("Ingresa el desplazamiento (1-25): ");
                    CDZ.SetDesplazamiento(int.Parse(Console.ReadLine()));
                    CDZ.Descifrar();
                    Console.WriteLine("El mensaje descifrado es: " + CDZ.GetMensajeOriginal());
                    break;
                case "5":
                    // Cifrar mensaje por AES
                    Console.WriteLine("Ingresa el mensaje de texto: ");
                    mensaje = Console.ReadLine();
                    CA = new CifradoAES(mensaje);

                    Console.WriteLine("Ingresa la clave para cifrar: ");
                    CA.SetClave(Console.ReadLine());
                    CA.Cifrar();
                    Console.WriteLine("El mensaje cifrado es: " + CA.GetMensajeOriginal());
                    break;
                case "6":
                    // Descifrar mensaje por AES
                    Console.WriteLine("Ingresa el mensaje cifrado: ");
                    mensaje = Console.ReadLine();
                    CA.SetMensajeOriginal(mensaje);

                    Console.WriteLine("Ingresa la clave para descifrar: ");
                    CA.SetClave(Console.ReadLine());
                    CA.Descifrar();
                    Console.WriteLine("El mensaje descifrado es: " + CA.GetMensajeOriginal());
                    break;
                case "7":
                    // Cifrado Doble
                    Console.WriteLine("Ingresa el mensaje: ");
                    mensaje = Console.ReadLine();
                    CD = new CifradoDoble(mensaje);

                    Console.WriteLine("Ingresa la clave principal: ");
                    CD.SetClave(Console.ReadLine());

                    Console.WriteLine("Ingresa la clave secundaria: ");
                    CD.SetClaveSecundaria(Console.ReadLine());
                    CD.Cifrar();
                    Console.WriteLine("El mensaje cifrado es: " + CD.GetMensajeOriginal());
                    break;
                case "8":
                    // Descifrado Doble
                    Console.WriteLine("Ingresa el mensaje cifrado: ");
                    mensaje = Console.ReadLine();
                    CD.SetMensajeOriginal(mensaje);

                    Console.WriteLine("Ingresa la clave principal: ");
                    CD.SetClave(Console.ReadLine());

                    Console.WriteLine("Ingresa la clave secundaria: ");
                    CD.SetClaveSecundaria(Console.ReadLine());
                    CD.Descifrar();
                    Console.WriteLine("El mensaje descifrado es: " + CD.GetMensajeOriginal());
                    break;
                case "9":
                    salir = true;
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }

    }
}
