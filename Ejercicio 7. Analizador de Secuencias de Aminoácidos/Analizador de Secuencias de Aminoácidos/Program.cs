/// <summary>
/// Clase Aminoacido que contiene el diccionario de aminoacidos
/// </summary>
public class Aminoacido
{
    //Diccionario que contiene la información de los aminoácidos
    private static Dictionary<string, string[]> _aminoacidos = new Dictionary<string, string[]>()
    {
        {"ALA", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"ARG", new [] {"Polar", "Cargado Positivo", "No Hidrofóbico"}},
        {"ASN", new [] {"Polar", "No Cargado", "No Hidrofóbico"}},
        {"ASP", new [] {"Polar", "Cargado Negativo", "No Hidrofóbico"}},
        {"CYS", new [] {"Polar", "No Cargado", "Hidrofóbico"}},
        {"GLN", new [] {"Polar", "No Cargado", "No Hidrofóbico"}},
        {"GLU", new [] {"Polar", "Cargado Negativo", "No Hidrofóbico"}},
        {"GLY", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"HIS", new [] {"Polar", "Cargado Positivo", "No Hidrofóbico"}},
        {"ILE", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"LEU", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"LYS", new [] {"Polar", "Cargado Positivo", "No Hidrofóbico"}},
        {"MET", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"PHE", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"PRO", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"SER", new [] {"Polar", "No Cargado", "No Hidrofóbico"}},
        {"THR", new [] {"Polar", "No Cargado", "No Hidrofóbico"}},
        {"TRP", new [] {"No Polar", "No Cargado", "Hidrofóbico"}},
        {"TYR", new [] {"Polar", "No Cargado", "No Hidrofóbico"}},
        {"VAL", new [] {"No Polar", "No Cargado", "Hidrofóbico"}}
    };

    //Propiedades de la clase
    public string Nombre { get; set; }
    public string Polaridad { get; set; }
    public string Carga { get; set; }
    public string Hidrofilicidad { get; set; }

    //Ejemplo de método que obtiene la polaridad de un aminoácido
    /// <summary>
    /// Método que permite obtener la polaridad de un aminoácido
    /// </summary>
    /// <param name="nombre"> Nombre del animoacido del que se quiere obtener la polaridad </param>
    /// <returns> String: Polaridad del aminoacido </returns>
    /// <exception cref="ArgumentException"> Excepción que indica que el aminoacido no se encuentra en la lista </exception>
    public static string ObtenerPolaridad(string nombre)
    {
        if (!_aminoacidos.ContainsKey(nombre))
        {
            throw new ArgumentException("El aminoácido no existe: " + nombre);
        }

        return _aminoacidos[nombre][0];
    }
    //Completar aquí métodos para obtener la carga y la hidrofilicidad

    /// <summary>
    /// Método que permite obtener la carga del un aminoácido
    /// </summary>
    /// <param name="nombre"> Nombre del aminoacido del que se solicita la carga </param>
    /// <returns> String: Carga del aminoacido </returns>
    /// <exception cref="ArgumentException"> Excepción que indica que el nombre del aminoácido no está en la lista </exception>
    // Método para obtener la carga
    public static string ObtenerCarga(String nombre)
    {
        if (!_aminoacidos.ContainsKey(nombre))
        {
            throw new ArgumentException("El aminoácido no existe: " + nombre);
        }

        return _aminoacidos[nombre][1];
    }

    // Método para obtener la hidrofilicidad
    /// <summary>
    /// Método que permite obtener la hidrofilicidad de un aminoácido
    /// </summary>
    /// <param name="nombre"> Nombre del aminoácido del que se solicita la hidrofilicidad </param>
    /// <returns> String: Hidrofilicidad del aminoácido </returns>
    /// <exception cref="ArgumentException"> Excepción que indica que el aminoácido no se encuentra en la lista </exception>
    public static string ObtenerHidrofilicidad(String nombre)
    {
        if (!_aminoacidos.ContainsKey(nombre))
        {
            throw new ArgumentException("El aminoácido no existe: " + nombre);
        }

        return _aminoacidos[nombre][2];
    }

    /// <summary>
    /// Método que permite validar que un aminoácido es válido, es decir, se encuentra en la lista de aminoácidos
    /// </summary>
    /// <param name="nombre"> Nombre del aminoácido a validar </param>
    /// <returns> Bool: true = se encuentra en la lista, false = no se encuentra en la lista </returns>
    public static bool ValidarAminoacido(String nombre)
    {
        if (!_aminoacidos.ContainsKey(nombre))
        {
            return false;
        }
        return true;
    }

}

//Clase de ejemplo de uso de la clase Aminoacido
/// <summary>
/// Clase Ejemplo - contiene al método Main 
/// </summary>
public static class Ejemplo
{
    /// <summary>
    /// Lista de aminoácidos ingresados en la secuencia que teclea el usuario 
    /// </summary>
    static List<string> aminoacidos = new List<string>();

    /// <summary>
    /// Método principal del programa - desde donde inicia el sistema 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n*****************************   !BIENVENIDO!   ********************************");
            Console.WriteLine("Se analizarán secuencias de aminoácidos para proporcionar información relevante\n");

            Console.WriteLine("1. Agregar secuencia de aminoácidos");
            Console.WriteLine("2. Analizar secuencia");
            Console.WriteLine("3. Ver resultados");
            Console.WriteLine("4. Salir\n");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarSecuencia(); 
                    break;
                case 2:
                    AnalizarSecuencia();
                    break;
                case 3:
                    VerResultados();
                    break;
                case 4:
                    Console.WriteLine("Saliste del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida, ingresa  nuevamente.");
                    break;
            }

        } while (opcion != 4);

    }

    /// <summary>
    /// Método que permite observar los resultados finales del análisis 
    /// </summary>
    public static void VerResultados()
    {
        Console.WriteLine("\n*** ANÁLISIS SIMPLE Y BÚSQUEDA DE PATRONES ***\n");

        BuscarPatronSecuenciasSenal();
        BuscarPatronSecuenciasUnion();
    }

    /// <summary>
    /// Método que busca el patrón de secuencia de señal en la secuencia de aminoácidos ingresada por el usuario
    /// Informa al usuario si la secuencia cumple con el patrón
    /// </summary>
    public static void BuscarPatronSecuenciasSenal()
    {
        if(aminoacidos.Count != 3)
        {
            Console.WriteLine("No cumple con el Patrón de Secuencias de Señal");
        }
        else
        {
            if (aminoacidos.ElementAt(1) == "SER" && aminoacidos.ElementAt(2) == "ARG")
            {
                Console.WriteLine("Sí cumple el Patrón de Secuencias de Señal (-n-Ser-Arg-)");
                Console.WriteLine("    * Secuencia que cuenta con 3 aminoácidos");
                Console.WriteLine("    * Contiene el aminoácido SER en su segunda posición");
                Console.WriteLine("    * Contiene el aminoácido ARG en su tercera posición\n");

            }
            else
            {
                Console.WriteLine("No cumple con el Patrón de Secuencias de Señal");
            }
        }
    }

    /// <summary>
    /// Método que busca el patrón de secuencia de unión en la secuencia de aminoácidos ingresada por el usuario
    /// Informa al usuario si la secuencia cumple con el patrón
    /// </summary>
    public static void BuscarPatronSecuenciasUnion()
    {
        if (aminoacidos.Count != 7)
        {
            Console.WriteLine("No cumple con el Patrón de Secuencia de Unión a Ligando");
        }
        else
        {
            if (aminoacidos.ElementAt(3) == "GLY")
            {
                Console.WriteLine("Sí cumple con el Patrón de Secuencia de Unión a Ligando (-x-x-x-Gly-x-x-x-)");
                Console.WriteLine("    * Secuencia que cuenta con 7 aminoácidos");
                Console.WriteLine("    * Contiene el aminoácido GLY en su cuarta posición\n");
            }
            else
            {
                Console.WriteLine("No cumple con el Patrón de Secuencia de Unión a Ligando");
            }
        }
    }

    /// <summary>
    /// Método que realiza el análisis básico de la secuencia ingresada por el usuario
    /// Informa el porcentaje de aminoácidos polares, cargados e hidrofóbicos
    /// </summary>
    public static void AnalizarSecuencia()
    {
        Console.WriteLine("\n*** ANÁLISIS DE SECUENCIA DE AMINOÁCIDOS ***\n");

        if(aminoacidos == null)
        {
            Console.WriteLine("No existen datos para analizar");
        }
        else
        {
            String secuencia = "";
            double totalAminoacidos = aminoacidos.Count;
            List<string> polares = new List<string>();
            List<string> cargados = new List<string>();
            List<string> hidrofobicos = new List<string>();

            for (int i = 0; i < aminoacidos.Count; i++)
            {
                secuencia = secuencia + "-" + aminoacidos[i];
                String polaridad = Aminoacido.ObtenerPolaridad(aminoacidos[i]);
                String carga = Aminoacido.ObtenerCarga(aminoacidos[i]);
                String hidrofilicidad = Aminoacido.ObtenerHidrofilicidad(aminoacidos[i]);

                if (polaridad.Equals("Polar"))
                {
                    polares.Add(aminoacidos[i]);
                }

                if (carga.Equals("Cargado Positivo"))
                {
                    cargados.Add(aminoacidos[i]);
                }

                if (hidrofilicidad.Equals("Hidrofóbico"))
                {
                    hidrofobicos.Add(aminoacidos[i]);
                }
            }

            Console.WriteLine("Secuencia: " + secuencia);
            Console.WriteLine("\nTotal de aminoacidos: " + totalAminoacidos);
            Console.WriteLine("Proporciones: ");

            double total = polares.Count;
            double porcentaje = ((total / totalAminoacidos) * 100);

            Console.Write($"    Polares: " + total + "/" + totalAminoacidos + " ({0}%) -", porcentaje);
            
            foreach (String dato in polares)
            {
                Console.Write(dato + ",");
            }

            total = cargados.Count;
            porcentaje = ((total / totalAminoacidos) * 100);

            Console.Write($"\n    Cargados: " + total + "/" + totalAminoacidos +" ({0}%) -", porcentaje);
            foreach (String dato in cargados)
            {
                Console.Write(dato + ",");
            }

            total = hidrofobicos.Count;
            porcentaje = ((total / totalAminoacidos) * 100);

            Console.Write($"\n    Hidrofóbicos: " + total + "/" + totalAminoacidos +" ({0}%) -", porcentaje);
            foreach (String dato in hidrofobicos)
            {
                Console.Write(dato + ",");
            }

            Console.WriteLine("");
        }

    }

    /// <summary>
    /// Método que almacena la secuencia ingresada por el usuario
    /// Valida que los aminoácidos encontrados en la secuencia sean parte del diccionario de aminoácidos permitidos
    /// </summary>
    public static void AgregarSecuencia()
    {
        bool secuenciaValida = false;

        do
        {
            // Limpiando la lista de aminoacidos ingresados
            aminoacidos.Clear();

            // Solicitando al usuario que ingrese datos
            Console.WriteLine("\n*** AGREGAR SECUENCIA DE AMINOÁCIDOS ***");
            Console.WriteLine("Ingresa la secuencia (Por ejemplo: ALA-SER-TYR-LYS-GLU): ");
            String dato = Console.ReadLine();

            // Eliminando espacios de la secuencia
            String secuencia = dato.Replace(" ", "");

            // Variable auxiliar para recuperar los aminoacidos por separado
            String aminoacido = "";

            // Recorre la secuencia de aminoacidos y recupear aminoacido por aminoacido
            for(int i = 0; i < secuencia.Length; i++)
            {
                // Si el elemento de la secuencia es un guión, se limpia la variable auxiliar aminoacido para almacenar uno nuevo
                if (secuencia[i].Equals('-'))
                {
                    aminoacido = "";
                }
                else // Si el elemento de la secuencia es una letra, se almacena en la variable auxiliar
                {
                    aminoacido = aminoacido + secuencia[i];
                    //Console.WriteLine(aminoacido);
                }

                // Si la variable auxiliar ya cuenta con una longitud de 3 elementos, guarda el aminoacido en la lista de aminoacidos
                if(aminoacido.Length == 3)
                {
                    aminoacidos.Add(aminoacido);
                }
            }

            // Valida los aminoacidos almacenados en la lista de aminoacidos ingresados
            // En caso de detectar que uno no está en la lista, volver a solicitar los aminoacidos

            bool aminoacidoValido = false;

            foreach (String amin in aminoacidos)
            {
                aminoacidoValido = Aminoacido.ValidarAminoacido(amin);

                if(!aminoacidoValido)
                {
                    Console.WriteLine("Secuencia inválida, ingresa nuevamente");
                    aminoacidoValido = false;
                    secuenciaValida = false;
                    break;
                }
                else
                {
                    secuenciaValida = true;
                }
                
            }

            if (secuenciaValida)
            {
                Console.WriteLine("Secuencia Agregada Exitosamente.");
            }

        } while (!secuenciaValida);
        
    }
}
