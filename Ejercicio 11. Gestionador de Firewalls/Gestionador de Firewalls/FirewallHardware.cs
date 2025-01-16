
namespace GestionadorFirewalls
{
    /// <summary>
    /// Clase derivada que especializa los objetos de tipo FirewallHardware
    /// </summary>
    public class FirewallHardware : Firewall
    {
        // Atributos
        private String Modelo { get; set; }
        private String IPPublica { get; set; }


        // Constructor
        public FirewallHardware(String nombre, String tipo, bool estado, String reglas, String modelo, String ipPublica) 
            : base(nombre, tipo, estado, reglas)
        {
            Modelo = modelo;
            IPPublica = ipPublica;
            Console.WriteLine("Firewall de tipo Hardware creado con éxito.");
        }


        /// <summary>
        /// Método que activa el firewall y muestra datos específicos del Firewall Hardware
        /// </summary>
        public override void Activar()
        {
            base.Activar();
            Console.WriteLine("\nFirewall Hardware Activado: \n" +
                "Modelo: " + Modelo + "\n" +
                "IP Pública: " + IPPublica + "\n");
        }

        /// <summary>
        /// Método que muestra la información completa del Firewall de Hardware 
        /// </summary>
        public override void MostrarEstado()
        {
            base.MostrarEstado();
            Console.WriteLine(
                "Modelo:" + Modelo + "\n" + 
                "Ip Pública: " + IPPublica + "\n");
        }
    }
}
