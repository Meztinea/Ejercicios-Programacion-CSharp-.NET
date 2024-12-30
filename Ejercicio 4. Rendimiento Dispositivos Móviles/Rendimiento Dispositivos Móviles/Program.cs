
namespace RendimientoDispositivosMoviles {

    /// <summary>
    /// Clase principal del programa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal del programa desde donde inicia el programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Evaluacion evaluacion = new Evaluacion();
            double[] limitesTPB = [1,2,3,5];

            int opcion;

            do
            {
                Console.WriteLine("\nMENÚ DE OPCIONES");
                Console.WriteLine("1. Ingresar datos");
                Console.WriteLine("2. Resultados de cálculos");
                Console.WriteLine("3. Resultados finales");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ingresarDatos(evaluacion);
                        break;
                    case 2:
                        mostrarResultadosCalculos(evaluacion);
                        break;
                    case 3:
                        mostrarResultadosfinales(evaluacion);
                        break;
                    default: Console.WriteLine("¡Opción Incorrecta!");
                        break;
                }

            } while (opcion != 4);

        }

        /// <summary>
        /// Método que permite al usuario ingresar los datos necesarios para realizar los cálculos
        /// </summary>
        /// <param name="evaluacion"> Objeto de tipo Evaluación donde se almacenan los datos que ingresa el usuario</param>
        public static void ingresarDatos(Evaluacion evaluacion)
        {
            Console.WriteLine("\nIngresa los siguientes datos");
            Console.WriteLine("Apps Para Evaluar: ");

            Console.Write("   Tamaño en MB: ");
            evaluacion.SetTamanioApps(double.Parse(Console.ReadLine()));

            Console.Write("   Tiempo de apertura de la app: ");
            evaluacion.SetTiempoAperturaApps(double.Parse(Console.ReadLine()));

            Console.WriteLine("Almacenamiento de Datos: ");
            Console.Write("   Tamaño de almacenamiento común: ");
            evaluacion.SetTamanioAlmacenamiento(double.Parse(Console.ReadLine()));

            Console.WriteLine("Rendimiento de la batería");
            Console.Write("   Promedio de aplicaciones abiertas: ");
            evaluacion.SetPromedioAppsAbiertas(double.Parse(Console.ReadLine()));

        }

        /// <summary>
        /// Método que permite mostrar los resultados de los cálculos
        /// </summary>
        /// <param name="evaluacion"> Objeto de tipo Evaluación donde se almacenan los datos que ingresa el usuario</param>
        public static void mostrarResultadosCalculos(Evaluacion evaluacion)
        {
            // Calculando el TPB
            double tamanioApp = evaluacion.GetTamanioApps();
            double tiempoAperturaApp = evaluacion.GetTiempoAperturaApps();
            evaluacion.SetTiempoProcesamientoMegabyte(MetodosReturn.calcularTPB(tamanioApp, tiempoAperturaApp));

            // Calculando el IE
            double tiempoProcesamientoMegabyte = evaluacion.GetTiempoProcesamientoMegabyte();
            double tamanioAlmacenamiento = evaluacion.GetTamanioAlmacenamiento();
            evaluacion.SetAlmacenamientoEficiente(MetodosReturn.calcularIE(tiempoProcesamientoMegabyte, 
                tamanioAlmacenamiento));

            // Calculando el AEA
            double almacenamientoEficiente = evaluacion.GetAlmacenamientoEficiente();
            double promedioAppsAbiertas = evaluacion.GetpromedioAppsAbiertas();
            evaluacion.SetAutonomiaEstimadaAplicacion(MetodosReturn.calcularAEA(almacenamientoEficiente,
                promedioAppsAbiertas));

            // Imprimiendo resultados de los cálculos
            Console.WriteLine("\nResultados de los cálculos");
            Console.WriteLine("    Velocidad de Procesamiento (TPB): ");
            Console.WriteLine("        TPB = " + tiempoAperturaApp + " / " + tamanioApp + 
                " = " + evaluacion.GetTiempoProcesamientoMegabyte() + " segundos/MB");
            Console.WriteLine("        Evaluación: " + calcularEvaluacionTPB(evaluacion.GetTiempoProcesamientoMegabyte()));

            Console.WriteLine("    Capacidad de Almacenamiento (IE): ");
            Console.WriteLine("        IE = " + tiempoProcesamientoMegabyte + " * " + tamanioAlmacenamiento +
                " = " + evaluacion.GetAlmacenamientoEficiente() + " segundos");
            Console.WriteLine("        Evaluación: " + calcularEvaluacionIE(evaluacion.GetAlmacenamientoEficiente()));

            Console.WriteLine("    Rendimiento de la bateria (AEA): ");
            Console.WriteLine("        AEA = " + almacenamientoEficiente + " / " + promedioAppsAbiertas +
                " = " + evaluacion.GetAutonomiaEstimadaAplicacion() + " segundos/app");
            Console.WriteLine("        Evaluación: " + calcularEvaluacionAEA(evaluacion.GetAutonomiaEstimadaAplicacion()));

        }

        /// <summary>
        /// Método que permite mostrar los resultados finales obtenidos con los cálculos
        /// </summary>
        /// <param name="evaluacion"> Objeto de tipo Evaluación donde se almacenan los datos que ingresa el usuario</param>
        public static void mostrarResultadosfinales(Evaluacion evaluacion)
        {
            Console.WriteLine("\nResultados Finales:");
            Console.WriteLine("    Velocidad de procesamiento (TPB): " +
                calcularEvaluacionTPB(evaluacion.GetTiempoProcesamientoMegabyte()));
            Console.WriteLine("    Capacidad de almacenamiento (IE): " +
                calcularEvaluacionIE(evaluacion.GetAlmacenamientoEficiente()));
            Console.WriteLine("    Rendimiento de la batería (AEA): " +
                calcularEvaluacionAEA(evaluacion.GetAutonomiaEstimadaAplicacion()));

        }

        /// <summary>
        /// Método que permite calcular la evaluación del TPB
        /// </summary>
        /// <param name="valor"> Dato de tipo double que indica el valor del TPB</param>
        /// <returns></returns>
        public static String calcularEvaluacionTPB(double valor)
        {
            if (valor >= 0.0 && valor <= 1.0)
            {
                return "Excelente";
            }
            else if (valor > 1.0 && valor <= 2.0)
            {
                return "Bueno";
            }
            else if (valor > 2.0 && valor <= 3.0)
            {
                return "Aceptable";
            }
            else if (valor > 3.0 && valor <= 5.0)
            {
                return "Regular";
            }
            else
            {
                return "Deficiente";
            }
        }

        /// <summary>
        /// Método que permite calcular la evaluación del IE
        /// </summary>
        /// <param name="valor">Dato de tipo double que indica el valor del IE</param>
        /// <returns></returns>
        public static String calcularEvaluacionIE(double valor)
        {
            if (valor >= 0.0 && valor <= 100)
            {
                return "Excelente";
            }
            else if (valor > 100 && valor <= 200)
            {
                return "Bueno";
            }
            else if (valor > 200 && valor <= 300)
            {
                return "Aceptable";
            }
            else if (valor > 300 && valor <= 400)
            {
                return "Regular";
            }
            else
            {
                return "Deficiente";
            }
        }

        /// <summary>
        /// Método que permite calcular la evaluación del AEA
        /// </summary>
        /// <param name="valor">Dato de tipo double que indica el valor del AEA</param>
        /// <returns></returns>
        public static String calcularEvaluacionAEA(double valor)
        {
            if (valor >= 0.0 && valor <= 9)
            {
                return "Deficiente";
            }
            else if (valor > 9 && valor <= 19)
            {
                return "Regular";
            }
            else if (valor > 19 && valor <= 29)
            {
                return "Aceptable";
            }
            else if (valor > 29 && valor <= 39)
            {
                return "Bueno";
            }
            else
            {
                return "Excelente";
            }
        }

    }

}
