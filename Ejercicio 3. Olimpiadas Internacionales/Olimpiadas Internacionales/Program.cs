
using OlimpiadasInternacionales;

namespace OlimpimpiadasInterlacionales
{
    /// <summary>
    /// Clase principal desde donde inicia el programa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Estructuras estáticas pertenecientes a la clase
        /// </summary>
        public static Participante[] participantes = new Participante[2];
        public static List<(string, double)> competencias = new List<(string, double)>();

        /// <summary>
        /// Método principal desde donde se inicia el programa 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int opcion;

            do
            {

                competencias.Add(("400 metros planos", 400));
                competencias.Add(("Carreras de relevos en 800 metros", 800));
                competencias.Add(("100 metros con obstáculos", 100));
                competencias.Add(("Caminata de 150 metros", 150));
                competencias.Add(("200 metros planos", 200));


                Console.WriteLine("Menú de Opciones: ");
                Console.WriteLine("1. Registro de Usuarios");
                Console.WriteLine("2. Asignar Competencia");
                Console.WriteLine("3. Registrar Tiempos");
                Console.WriteLine("4. Clasificación del Ganador");
                Console.WriteLine("5. Calcular la Velocidad");
                Console.WriteLine("6. Conocer al Ganador Final");

                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        registarUsuarios(participantes);
                        break;
                    case 2:
                        asignarCompetencia(participantes, competencias);
                        break;
                    case 3:
                        registrarTiempos(participantes);
                        break;
                    case 4:
                        clasificarGanador(participantes);
                        break;
                    case 5:
                        calcularVelocidad(participantes);
                        break;
                    case 6:
                        ConocerGanadorFinal(participantes);
                        break;
                    case 7:
                        Console.WriteLine("Saliste del programa");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, selecciona nuevamente.");
                        break;
                }

            } while (opcion != 7);

        }

        /// <summary>
        /// Método que permite al usuario ingresar los datos sobre los participantes
        /// </summary>
        /// <param name="participantes">Array de tipo Participante que almacena los participantes </param>
        public static void registarUsuarios(Participante[] participantes)
        {
            for (int i = 0; i < 2; i++)
            {
                participantes[i] = new Participante();

                Console.WriteLine("\nREGISTRA AL PARTICIPANTE #" + (i+1));

                Console.Write("Ingresa el nombre y apellido: ");
                participantes[i].SetNombreYApellido(Console.ReadLine());

                Console.Write("Ingresa el numero de participante: ");
                participantes[i].SetNoParticipante(int.Parse(Console.ReadLine()));

                Console.Write("Ingresa el país natal: ");
                participantes[i].SetPaisNatal(Console.ReadLine());

                Console.Write("Ingresa la edad: ");
                participantes[i].SetEdad(int.Parse(Console.ReadLine()));

                Console.Write("Ingresa el continente: ");
                participantes[i].SetContinente(Console.ReadLine());

            }

            Console.WriteLine("");
        }
        
        /// <summary>
        /// Método que asigna una competencia a los participantes
        /// </summary>
        /// <param name="participantes"> Array de tipo Participante que almacena a los participantes </param>
        /// <param name="competencias"> List que almacena las competencias disponibles </param>
        public static void asignarCompetencia(Participante[] participantes, List<(string, double)> competencias)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(0, 5); // incluye al 0 y excluye al 5. 

            String nombreCompetencia = competencias[numeroAleatorio].Item1;
            double distancia = competencias[numeroAleatorio].Item2;

            for (int i = 0; i < 2; i++)
            {
                participantes[i].SetCompetencia(nombreCompetencia, distancia);
            }

            Console.WriteLine("\nSe ha asignado la competencia: " + nombreCompetencia + "\n");
        }

        /// <summary>
        /// Método que permite al usuario registrar el tiempo en que cada participante terminó la prueba
        /// </summary>
        /// <param name="participantes"> Array de tipo Participante que almacena a los participantes </param>
        public static void registrarTiempos(Participante[] participantes)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\nIngresa el tiempo para el participante " + 
                    participantes[i].GetNombreYApellido() + ": ");

                participantes[i].GetCompetencia().SetTiempo(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// Método que permite identificar al usuario que terminó la prueba en el menor tiempo 
        /// </summary>
        /// <param name="participantes"> Array de tipo Participante que almacena a los participantes </param>
        public static void clasificarGanador(Participante[] participantes)
        {
            double tiempoP1 = participantes[0].GetCompetencia().GetTiempo();
            double tiempoP2 = participantes[1].GetCompetencia().GetTiempo();

            Console.WriteLine("\nEl tiempo del participante: " + participantes[0].GetNombreYApellido() + " es: " + tiempoP1);
            Console.WriteLine("El tiempo del participante: " + participantes[1].GetNombreYApellido() + " es: " + tiempoP2);
            Console.WriteLine("");

            if (tiempoP1 < tiempoP2)
            {
                Console.WriteLine("El mejor tiempo es el del participante: " + 
                    participantes[0].GetNombreYApellido());
            }
            else
            {
                Console.WriteLine("El mejor tiempo es el del participante: " +
                    participantes[1].GetNombreYApellido());
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// Método que permite calcular la velocidad en que cada participante terminó la competencia
        /// </summary>
        /// <param name="participantes"> Array de tipo Participante que almacena a los participantes </param>
        public static void calcularVelocidad(Participante[] participantes)
        {
            double distancia;
            double tiempo;
            double velocidad;

            for (int i = 0; i < 2; i++)
            {
                distancia = participantes[i].GetCompetencia().GetDistancia();
                tiempo = participantes[i].GetCompetencia().GetTiempo();
                velocidad = distancia / tiempo;

                participantes[i].GetCompetencia().SetVelocidad(velocidad);
            }

            Console.WriteLine("\nVelocidad calculada exitosamente para los participantes.\n");

        }

        /// <summary>
        /// Método que permite identificar al ganador final de la competencia
        /// </summary>
        /// <param name="participantes"> Array de tipo Participante que almacena a los participantes </param>
        public static void ConocerGanadorFinal(Participante[] participantes)
        {
            double velocidadP1 = participantes[0].GetCompetencia().GetVelocidad();
            double velocidadP2 = participantes[1].GetCompetencia().GetVelocidad();

            if (velocidadP1 > velocidadP2)
            {
                Console.WriteLine("\nLa mayor velocidad es del participante: " +
                    participantes[0].GetNombreYApellido() + " de " + participantes[0].GetPaisNatal() + "\n" +
                    "!Felicidades por este gran logro!");
            }
            else
            {
                Console.WriteLine("\nLa mayor velocidad es del participante: " +
                    participantes[1].GetNombreYApellido() + " de " + participantes[0].GetPaisNatal() + "\n" +
                    "!Felicidades por este gran logro!");
            }

            Console.WriteLine("");
        }

    }

}
