
namespace GestionadorFirewalls
{
    /// <summary>
    /// Clase que define a los objetos de tipo FirewallAvanzado - contiene objetos de tipo firewall
    /// </summary>
    public class FirewallAvanzado
    {
        // Atributos
        public FirewallHardware hardwareFirewall { get; set; }
        public FirewallSoftware softwareFirewall { get; set; }
        private String TecnologiasSoportadas { get; set; }


        // Constructor
        public FirewallAvanzado(String nombre, String tipo, bool estado, String reglas, String modelo, String ipPublica,
            String version, String licencia, String tecnologiasSoportadas)
        {
            this.hardwareFirewall = new FirewallHardware(nombre, tipo, estado, reglas, modelo, ipPublica);
            this.softwareFirewall = new FirewallSoftware(nombre, tipo, estado, reglas, version, licencia);
            this.TecnologiasSoportadas = tecnologiasSoportadas;
        }

        /// <summary>
        /// Método que activa el firewall - Activa los dos firewall que contiene
        /// </summary>
        public virtual void Activar()
        {
            hardwareFirewall.Activar();
            softwareFirewall.Activar();
            Console.WriteLine("\nFirewall Avanzado se ha activado" + "\n" +
                "Tecnologías soportadas: " + TecnologiasSoportadas);
        }

        /// <summary>
        /// Método que muestra el estado de los dos tipos de firewall que contiene
        /// </summary>
        public virtual void MostrarEstado()
        {
            hardwareFirewall.MostrarEstado();
            softwareFirewall.MostrarEstado();
            Console.WriteLine("\nTecnologías soportadas: " + TecnologiasSoportadas);
        }

        /// <summary>
        /// Método que desactiva a los dos firewalls que contiene
        /// </summary>
        public virtual void Desactivar()
        {
            hardwareFirewall.Desactivar();
            softwareFirewall.Desactivar();
        }
    }
}
