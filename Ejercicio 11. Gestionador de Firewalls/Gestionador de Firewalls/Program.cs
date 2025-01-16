
using GestionadorFirewalls;

public class Program
{
    /// <summary>
    /// Clase principal - desde donde comienza el programa
    /// </summary>
    public static FirewallHardware fHardware;
    public static FirewallSoftware fSoftware;
    public static FirewallAvanzado fAvanzado;
    public static FirewallInteligente fInteligente;

    /// <summary>
    /// Método principal desde donde inicia el programa
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        
        bool seguir = true;

        while (seguir)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Crear Instancias de Firewalls");
            Console.WriteLine("2. Activar / Desactivar Firewalls");
            Console.WriteLine("3. Agregar Reglas de Seguridad");
            Console.WriteLine("4. Mostrar Estado de los Firewalls");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Program.CrearInstancias();
                    break;
                case "2":
                    Program.ActivarDesactivarFirewalls();
                    break;
                case "3":
                    Program.AgregarReglasSeguridad();
                    break;
                case "4":
                    Program.MostrarEstado();
                    break;
                case "5":
                    Console.WriteLine("Saliendo del programa...");
                    seguir = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    /// <summary>
    /// Método que gestiona la creación de instancias de firewalls
    /// </summary>
    public static void CrearInstancias()
    {
        Console.WriteLine("*** CREAR INSTANCIAS DE FIREWALLS ***");
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Instancia de Firewall Hardware");
            Console.WriteLine("2. Instancia de Firewall Software");
            Console.WriteLine("3. Instancia de Firewall Avanzado");
            Console.WriteLine("4. Instancia de Firewall Inteligente");
            Console.WriteLine("5. Regresar al menú principal");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Seleccionaste instancia de Hardware");
                    Console.WriteLine("Ingresa el nombre: ");
                    string nombreH = Console.ReadLine();

                    Console.WriteLine("Ingresa el modelo: ");
                    string modeloH = Console.ReadLine();

                    Console.WriteLine("Ingresa la IP pública: ");
                    string ipPublicaH = Console.ReadLine();

                    Program.fHardware = new FirewallHardware(nombreH, "Hardware", false, "", modeloH, ipPublicaH);
                    break;
                case "2":
                    Console.WriteLine("Seleccionaste instancia de Software");
                    Console.WriteLine("Ingresa el nombre: ");
                    string nombreS = Console.ReadLine();

                    Console.WriteLine("Ingresa la versión: ");
                    string versionS = Console.ReadLine();

                    Console.WriteLine("Ingresa la licencia: ");
                    string licenciaS = Console.ReadLine();

                    Program.fSoftware = new FirewallSoftware(nombreS, "Software", false, "", versionS, licenciaS);

                    break;
                case "3":
                    Console.WriteLine("Seleccionaste instancia Avanzada");
                    Console.WriteLine("Ingresa el nombre: ");
                    string nombreA = Console.ReadLine();

                    Console.WriteLine("Ingresa la modelo del firewall de Hardware: ");
                    string modeloA = Console.ReadLine();

                    Console.WriteLine("Ingresa la IP pública del firewall de Hardware: ");
                    string ipPublicaA = Console.ReadLine();

                    Console.WriteLine("Ingresa la versión del firewall de Software: ");
                    string versionA = Console.ReadLine();

                    Console.WriteLine("Ingresa la licencia del firewall de Software: ");
                    string licenciaA = Console.ReadLine();

                    Console.WriteLine("Ingresa las tecnologías soportadas: ");
                    string tecSoportadas = Console.ReadLine();

                    Program.fAvanzado = new FirewallAvanzado(nombreA, "Avanzado (H y S)", false, "", modeloA, ipPublicaA,
                        versionA, licenciaA, tecSoportadas);

                    break;
                case "4":
                    Console.WriteLine("Seleccionaste instancia Inteligente");
                    Console.WriteLine("Ingresa el nombre: ");
                    string nombreI = Console.ReadLine();

                    Console.WriteLine("Ingresa la modelo del firewall de Hardware: ");
                    string modeloI = Console.ReadLine();

                    Console.WriteLine("Ingresa la IP pública del firewall de Hardware: ");
                    string ipPublicaI = Console.ReadLine();

                    Console.WriteLine("Ingresa la versión del firewall de Software: ");
                    string versionI = Console.ReadLine();

                    Console.WriteLine("Ingresa la licencia del firewall de Software: ");
                    string licenciaI = Console.ReadLine();

                    Console.WriteLine("Ingresa las tecnologías soportadas: ");
                    string tecSoportadasI = Console.ReadLine();

                    Console.WriteLine("Ingresa el nivel de inteligencia (1-10): ");
                    int nivelInteligencia = int.Parse(Console.ReadLine());

                    Program.fInteligente = new FirewallInteligente(nombreI, "Inteligente", false, "", modeloI, ipPublicaI,
                        versionI, licenciaI, tecSoportadasI, nivelInteligencia, "");

                    break;
                case "5":
                    Console.WriteLine("Regresando al menú principal...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    /// <summary>
    /// Método gestiona la activación o desactivación de los firewalls con un menú interactivo
    /// </summary>
    public static void ActivarDesactivarFirewalls()
    {

        Console.WriteLine("*** ACTIVAR O DESACTIVAR FIREWALLS ***");
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Activar / Desactivar Firewall de Hardware");
            Console.WriteLine("2. Activar / Desactivar Firewall de Software");
            Console.WriteLine("3. Activar / Desactivar Firewall Avanzado");
            Console.WriteLine("4. Activar / Desactivar Firewall Inteligente");
            Console.WriteLine("5. Regresar al menú principal");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Activar / Desactivar Firewall de Hardware");
                    Console.WriteLine("Qué quieres hacer? A = Activar  D = Desactivar");
                    char eleccion = char.Parse(Console.ReadLine());

                    if(eleccion.Equals('A') || eleccion.Equals('a'))
                    {
                        fHardware.Activar();
                    } 
                    else if (eleccion.Equals('D') || eleccion.Equals('d'))
                    {
                        fHardware.Desactivar();
                    }
                    else
                    {
                        Console.WriteLine("Elección inválida. Comienza nuevamente. ");
                    }
                    break;
                case "2":
                    Console.WriteLine("Activar / Desactivar Firewall de Software");
                    Console.WriteLine("Qué quieres hacer? A = Activar  D = Desactivar");
                    char eleccion1 = char.Parse(Console.ReadLine());

                    if (eleccion1.Equals('A') || eleccion1.Equals('a'))
                    {
                        fSoftware.Activar();
                    }
                    else if (eleccion1.Equals('D') || eleccion1.Equals('d'))
                    {
                        fSoftware.Desactivar();
                    }
                    else
                    {
                        Console.WriteLine("Elección inválida. Comienza nuevamente. ");
                    }
                    break;
                case "3":
                    Console.WriteLine("Activar / Desactivar Firewall Avanzado");
                    Console.WriteLine("Qué quieres hacer? A = Activar  D = Desactivar");
                    char eleccion2 = char.Parse(Console.ReadLine());

                    if (eleccion2.Equals('A') || eleccion2.Equals('a'))
                    {
                        fAvanzado.Activar();
                    }
                    else if (eleccion2.Equals('D') || eleccion2.Equals('d'))
                    {
                        fAvanzado.Desactivar();
                    }
                    else
                    {
                        Console.WriteLine("Elección inválida. Comienza nuevamente. ");
                    }
                    break;
                case "4":
                    Console.WriteLine("Activar / Desactivar Firewall Inteligente");
                    Console.WriteLine("Qué quieres hacer? A = Activar  D = Desactivar");
                    char eleccion3 = char.Parse(Console.ReadLine());

                    if (eleccion3.Equals('A') || eleccion3.Equals('a'))
                    {
                        fInteligente.Activar();
                    }
                    else if (eleccion3.Equals('D') || eleccion3.Equals('d'))
                    {
                        fInteligente.Desactivar();
                    }
                    else
                    {
                        Console.WriteLine("Elección inválida. Comienza nuevamente. ");
                    }
                    break;
                case "5":
                    Console.WriteLine("Regresando al menú principal...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    /// <summary>
    /// Método que gestiona la agregación de reglas de seguridad por medio de un menú interactivo
    /// </summary>
    public static void AgregarReglasSeguridad()
    {

        Console.WriteLine("*** AGREGAR REGLAS DE SEGURIDAD A FIREWALLS ***");
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Agregar reglas a Firewall de Hardware");
            Console.WriteLine("2. Agregar reglas a Firewall de Software");
            Console.WriteLine("3. Agregar reglas a Firewall Avanzado");
            Console.WriteLine("4. Agregar reglas a Firewall Inteligente");
            Console.WriteLine("5. Regresar al menú principal");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Agregar reglas de seguridad a Firewall de Hardware");
                    Console.WriteLine("Ingresa las reglas separadas por comas: ");
                    String reglasH = Console.ReadLine();

                    fHardware.AgregarRegla(reglasH);
                    break;
                case "2":
                    Console.WriteLine("Agregar reglas de seguridad a Firewall de Software");
                    Console.WriteLine("Ingresa las reglas separadas por comas: ");
                    String reglasS = Console.ReadLine();

                    fSoftware.AgregarRegla(reglasS);
                    break;
                case "3":
                    Console.WriteLine("Agregar reglas de seguridad a Firewall Avanzado");

                    Console.WriteLine("Ingresa las reglas para el firewall de hardware separadas por comas: ");
                    String reglasFH = Console.ReadLine();
                    fAvanzado.hardwareFirewall.AgregarRegla(reglasFH);

                    Console.WriteLine("Ingresa las reglas para el firewall de software separadas por comas: ");
                    String reglasFS = Console.ReadLine();
                    fAvanzado.softwareFirewall.AgregarRegla(reglasFS);

                    break;
                case "4":
                    Console.WriteLine("Agregar reglas de seguridad a Firewall Inteligente");

                    Console.WriteLine("Ingresa las reglas para el firewall de hardware separadas por comas: ");
                    String reglasFHI = Console.ReadLine();
                    fInteligente.hardwareFirewall.AgregarRegla(reglasFHI);

                    Console.WriteLine("Ingresa las reglas para el firewall de software separadas por comas: ");
                    String reglasFSI = Console.ReadLine();
                    fInteligente.softwareFirewall.AgregarRegla(reglasFSI);

                    break;
                case "5":
                    Console.WriteLine("Regresando al menú principal...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    /// <summary>
    /// Método que imprime en pantalla la información sobre el estado de los firewalls 
    /// </summary>
    public static void MostrarEstado()
    {

        Console.WriteLine("*** ESTADO DE FIREWALLS ***");

        fHardware.MostrarEstado();
        fSoftware.MostrarEstado();
        fAvanzado.MostrarEstado();
        fInteligente.MostrarEstado();
    }

}