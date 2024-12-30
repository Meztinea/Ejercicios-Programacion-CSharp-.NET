
namespace PrevencionDesastresNaturales
{
    /// <summary>
    /// Clase principal desde donde se ejecuta el programa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Atributos estáticos pertenecientes a la clase - almacenan los datos necesarios para realizar cálculos
        /// </summary>
        static double velocidadViento, cantidadLluvia, porcentajeArcilla, porcentajeArena, porcentajeOtros;

        /// <summary>
        /// Método principal desde donde comienza el programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int opcion;

            do
            {
                Console.WriteLine("MENÚ DE OPCIONES");
                Console.WriteLine("1. Recopilar datos");
                Console.WriteLine("2. Analizar datos");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nIngresa los siguientes datos");
                        RecopilarDatosClima();
                        RecopilarDatosSuelo();
                        break;
                    case 2:
                        Console.WriteLine("\nEl Riesgo de Inundacion es: " + CalcularRiesgoInundacion(velocidadViento, 
                            cantidadLluvia, porcentajeArcilla, porcentajeArena, porcentajeOtros));
                        Console.WriteLine("Zona identificada como: " + IdentificarZonasSismicamenteActivas(porcentajeArcilla,
                            porcentajeArena, porcentajeOtros));
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("¡Opción Incorrecta!");
                        break;
                }

            } while (opcion != 3);

        }    

        /// <summary>
        /// Método que recopila datos del clima que el usuario ingresa por teclado
        /// </summary>
        public static void RecopilarDatosClima()
        {
            // Solicita velocidad del viento
            Console.Write("    Velocidad del Viento [0 /ms, 30 m/s] (rango típico): ");
            velocidadViento = int.Parse(Console.ReadLine());

            // Solicita cantidad de lluvia
            Console.Write("    Cantidad de Lluvia [0 mm, 100 mm] (rango típico): ");
            cantidadLluvia = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Método que recopila datos del suelo que el usuario ingresa por teclado
        /// </summary>
        public static void RecopilarDatosSuelo()
        {
            // Solicita porcentaje de Archilla
            Console.Write("    Porcentaje de Arcilla [0 %, 50%]: ");
            porcentajeArcilla = int.Parse(Console.ReadLine());

            // Solicita porcentaje de Arena
            Console.Write("    Porcentaje de Arena [0 %, 50%]: ");
            porcentajeArena = int.Parse(Console.ReadLine());

            // Solicita porcentaje de otros componentes
            Console.Write("    Porcentaje de Otros Componentes [0 %, 50%]: ");
            porcentajeOtros = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        /// <summary>
        /// Método que calcula el riesgo de inundación
        /// </summary>
        /// <param name="velViento"> Dato de tipo double que representa la velocidad del viento </param>
        /// <param name="cantLluvia"> Dato de tipo double que representa la cantidad de lluvia </param>
        /// <param name="porcArcilla"> Dato de tipo double que representa el porcentaje de arcilla </param>
        /// <param name="porcArena"> Dato de tipo double que representa el porcentaje de arena </param>
        /// <param name="porcOtros"> Dato de tipo double que representa el porcentaje de otros componentes </param>
        /// <returns> Dato de tipo double que representa el riesgo de inundación </returns>
        public static double CalcularRiesgoInundacion(double velViento, double cantLluvia, double porcArcilla,
            double porcArena, double porcOtros)
        {
            // Verifica que existen datos suficientes
            if(velViento <= 0 || cantLluvia <= 0 || porcArcilla <= 0 || porcArena <= 0 || porcOtros <= 0 )
            {
                Console.Write("\nNo hay datos suficientes para analizar.");
            }

            // Normaliza la composición del suelo
            double sumaTotal = porcArcilla + porcArena + porcOtros;

            porcArcilla = (porcArcilla / sumaTotal) * 100;
            porcArena = (porcArena / sumaTotal) * 100;
            porcOtros = (porcOtros / sumaTotal) * 100;

            // Calcula el Factor de Corrección 
            // Factor de Corrección = 1 + (Porcentaje de Arcilla * 0.1) + (Porcentaje de Arena *0.05) +
            // (Porcentaje de Otros Componentes * 0.07).

            double factorCorreccion = 1 + (porcArcilla * 0.1) + (porcArena * 0.05) + (porcOtros * 0.07);

            // Calcula el riesgo de inundación
            // Riesgo de Inundación = (Velocidad del Viento * Cantidad de Lluvia) / Factor de Corrección.

            double riesgoInundacion = (velViento * cantLluvia) / factorCorreccion;

            return riesgoInundacion;
        }

        /// <summary>
        /// Método que identifica si una zona es sísmica o no
        /// </summary>
        /// <param name="porcArcilla"> Dato de tipo double que representa el porcentaje de arcilla </param>
        /// <param name="porcArena"> Dato de tipo double que representa el porcentaje de arena </param>
        /// <param name="porcOtros"> Dato de tipo double que representa el porcentaje de otros componentes </param>
        /// <returns> String que indica si la zona es sísmica o no </returns>
        public static String IdentificarZonasSismicamenteActivas(double porcArcilla, double porcArena, double porcOtros)
        {
            // Verifica que existen datos suficientes para calcular
            if (porcArcilla <= 0 || porcArena <= 0 || porcOtros <= 0)
            {
                Console.Write("\nNo hay datos suficientes para analizar.");
                return "";
            }

            // Define el umbral para clasificar zonas sismicamente activas
            double umbralSismico = 0.7;

            // Calcula el Factor de Actividad Sísmica
            // Factor de Actividad Sísmica = (Porcentaje de Arcilla * 0.2) + (Porcentaje de Arena *0.1) +
            // (Porcentaje de Otros Componentes * 0.05).
            double factorActividadSismica = (porcArcilla * 0.2) + (porcArena * 0.1) + (porcOtros * 0.05);
            
            // Si el factor supera el umbral ubica la zona en zonas activas
            if ( factorActividadSismica > umbralSismico)
            {
                return "Zona con Actividad Sísmica";
            }

            return "Zona sin Actividad Sísmica";
        }
    }
}
