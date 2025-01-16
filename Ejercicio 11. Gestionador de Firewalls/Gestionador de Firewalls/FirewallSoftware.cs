
namespace GestionadorFirewalls
{
    /// <summary>
    /// Clase derivada que especializa los objetos de tipo FirewallSoftware
    /// </summary>
    public class FirewallSoftware: Firewall
    {
        // Atributos
        private String Version { get; set; }
        private String Licencia { get; set; }


        // Constructor 
        public FirewallSoftware(String nombre, String tipo, bool estado, String reglas, String version, String licencia)
            : base(nombre, tipo, estado, reglas)
        {
            Version = version;
            Licencia = licencia;
            Console.WriteLine("Firewall de tipo Software creado con éxito.");
        }

        /// <summary>
        /// Método que activa los firewall y muestra información específica del objeto
        /// </summary>
        public override void Activar()
        {
            base.Activar();
            Console.WriteLine("\nFirewall Software Activado: \n" +
                "Version: " + Version + "\n" +
                "Licencia: " + Licencia + "\n");
        }

        /// <summary>
        /// Método que muestra el estado del firewall incluyendo información específica del objeto
        /// </summary>
        public override void MostrarEstado()
        {
            base.MostrarEstado();
            Console.WriteLine(
                "Version: " + Version + "\n" +
                "Licencia: " + Licencia + "\n");
        }
    }
}
