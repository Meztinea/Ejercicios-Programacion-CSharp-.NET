
using Geolocation;

namespace GeolocalizacionTortugasMarinas
{
    /// <summary>
    /// Clase principal desde donde se ejecuta el programa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal donde se ejecuta el programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            RecorridoDia recorridoDia1 = new ();
            RecorridoDia recorridoDia2 = new ();
            RecorridoDia recorridoDia3 = new ();

            int opcion;

            do
            {

                Console.WriteLine("Menú de Opciones: ");
                Console.WriteLine("1. Registro de Datos de Seguimiento");
                Console.WriteLine("2. Calcular Distancia y Dirección");
                Console.WriteLine("3. Calcular Tiempo y Velocidad Promedio");
                Console.WriteLine("4. Generar Informe Completo");

                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarDatos(recorridoDia1, recorridoDia2, recorridoDia3);
                        break;
                    case 2:
                        CalcularDistanciaDireccion(recorridoDia1, recorridoDia2, recorridoDia3);
                        break;
                    case 3:
                        CalcularTiempoVelocidad(recorridoDia1, recorridoDia2, recorridoDia3);
                        break;
                    case 4:
                        GenerarInforme(recorridoDia1, recorridoDia2, recorridoDia3);
                        break;
                    case 5:
                        Console.WriteLine("Saliste del programa");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, selecciona nuevamente.");
                        break;
                }

            } while (opcion != 5);

        }
        /// <summary>
        /// Método que permite al usuario ingresar los datos de coordenada de inicio y coordenada de fin
        /// para tres días
        /// </summary>
        /// <param name="rec1">Recorrido del día 1</param>
        /// <param name="rec2">Recorrido del día 2</param>
        /// <param name="rec3">Recorrido del día 3</param>
        public static void RegistrarDatos(RecorridoDia rec1, RecorridoDia rec2, RecorridoDia rec3)
        {
            
            Console.WriteLine("\nREGISTRO DE DATOS\n");
            Console.WriteLine("Ingresa los datos del día #1");
            rec1.SetCoordenadaInicio(UtilitariosHelpers.IngresarDatosCoordenada("Inicio"));
            rec1.SetCoordenadaFin(UtilitariosHelpers.IngresarDatosCoordenada("Fin"));
            Console.WriteLine("");

            Console.WriteLine("Ingresa los datos del día #2");
            rec2.SetCoordenadaInicio(UtilitariosHelpers.IngresarDatosCoordenada("Inicio"));
            rec2.SetCoordenadaFin(UtilitariosHelpers.IngresarDatosCoordenada("Fin"));
            Console.WriteLine("");

            Console.WriteLine("Ingresa los datos del día #3");
            rec3.SetCoordenadaInicio(UtilitariosHelpers.IngresarDatosCoordenada("Inicio"));
            rec3.SetCoordenadaFin(UtilitariosHelpers.IngresarDatosCoordenada("Fin"));

            Console.WriteLine("DATOS ALMACENADOS CON ÉXITO\n\n");

        }
        /// <summary>
        /// Método que muestra la distancia y direccion de recorrido de los tres días
        /// </summary>
        /// <param name="rec1">Recorrido del día 1</param>
        /// <param name="rec2">Recorrido del día 2</param>
        /// <param name="rec3">Recorrido del día 3</param>
        public static void CalcularDistanciaDireccion(RecorridoDia rec1, RecorridoDia rec2, RecorridoDia rec3)
        {
            Console.WriteLine("\nCALCULO DE DISTANCIA Y DIRECCIÓN");

            Console.WriteLine("\nDatos del día #1");
            rec1.setDistanciaKM(UtilitariosHelpers.CalcularDistanciaKm(rec1));
            Console.WriteLine("Distancia en Kilómetros: " + rec1.GetDistanciaKM());
            rec1.setDireccion(UtilitariosHelpers.CalcularDireccionCardinal(rec1));
            Console.WriteLine("Dirección cardinal: " + rec1.GetDireccion());

            Console.WriteLine("\nDatos del día #2");
            rec2.setDistanciaKM(UtilitariosHelpers.CalcularDistanciaKm(rec2));
            Console.WriteLine("Distancia en Kilómetros: " + rec2.GetDistanciaKM());
            rec2.setDireccion(UtilitariosHelpers.CalcularDireccionCardinal(rec2));
            Console.WriteLine("Dirección cardinal: " + rec2.GetDireccion());

            Console.WriteLine("\nDatos del día #3");
            rec3.setDistanciaKM(UtilitariosHelpers.CalcularDistanciaKm(rec3));
            Console.WriteLine("Distancia en Kilómetros: " + rec3.GetDistanciaKM());
            rec3.setDireccion(UtilitariosHelpers.CalcularDireccionCardinal(rec3));
            Console.WriteLine("Dirección cardinal: " + rec3.GetDireccion());
            Console.WriteLine("");
        }
        /// <summary>
        /// Método que muestra los datos de tiempo y velocidad promedio de nado
        /// </summary>
        /// <param name="rec1">Recorrido del día 1</param>
        /// <param name="rec2">Recorrido del día 2</param>
        /// <param name="rec3">Recorrido del día 3</param>
        public static void CalcularTiempoVelocidad(RecorridoDia rec1, RecorridoDia rec2, RecorridoDia rec3)
        {
            rec1.setTiempoTranscurrido(UtilitariosHelpers.CalcularTiempoTranscurrido(rec1));
            rec2.setTiempoTranscurrido(UtilitariosHelpers.CalcularTiempoTranscurrido(rec2));
            rec3.setTiempoTranscurrido(UtilitariosHelpers.CalcularTiempoTranscurrido(rec3));

            rec1.SetVelocidadPromedioNado(UtilitariosHelpers.CalcularVelocidadNado(rec1));
            rec2.SetVelocidadPromedioNado(UtilitariosHelpers.CalcularVelocidadNado(rec2));
            rec3.SetVelocidadPromedioNado(UtilitariosHelpers.CalcularVelocidadNado(rec3));

            Console.WriteLine("\nDatos del día #1");
            Console.WriteLine("Tiempo Transcurrido: " + rec1.GetTiempoTranscurrido());
            Console.WriteLine("Velocidad Promedio de Nado: " + rec1.GetVelocidadPromedioNado().ToString("N2"));

            Console.WriteLine("\nDatos del día #2");
            Console.WriteLine("Tiempo Transcurrido: " + rec2.GetTiempoTranscurrido());
            Console.WriteLine("Velocidad Promedio de Nado: " + rec2.GetVelocidadPromedioNado().ToString("N2"));

            Console.WriteLine("\nDatos del día #3");
            Console.WriteLine("Tiempo Transcurrido: " + rec3.GetTiempoTranscurrido());
            Console.WriteLine("Velocidad Promedio de Nado: " + rec3.GetVelocidadPromedioNado().ToString("N2"));
            Console.WriteLine("");
        }
        /// <summary>
        /// Método que permite mostrar el informe general de los tres días de recorrido
        /// </summary>
        /// <param name="rec1">Recorrido del día 1</param>
        /// <param name="rec2">Recorrido del día 2</param>
        /// <param name="rec3">Recorrido del día 3</param>
        public static void GenerarInforme(RecorridoDia rec1, RecorridoDia rec2, RecorridoDia rec3)
        {
            Console.WriteLine("\nDatos del día #1");
            UtilitariosHelpers.ImprimirInforme(rec1);
            
            Console.WriteLine("\nDatos del día #2");
            UtilitariosHelpers.ImprimirInforme(rec2);

            Console.WriteLine("\nDatos del día #3");
            UtilitariosHelpers.ImprimirInforme(rec3);

            Console.WriteLine("\nRESUMEN DE TODA LA RUTA");
            Console.WriteLine("Distancia total recorrida: " + (rec1.GetDistanciaKM() + rec2.GetDistanciaKM() + 
                rec3.GetDistanciaKM()));
            double velocidadPromedioTotal = (rec1.GetVelocidadPromedioNado() + rec2.GetVelocidadPromedioNado() + 
                rec3.GetVelocidadPromedioNado()) / 3;
            Console.WriteLine("Velocidad promedio de nado de toda la ruta: " + velocidadPromedioTotal.ToString("N2"));
            Console.WriteLine("");
        }
    }
}