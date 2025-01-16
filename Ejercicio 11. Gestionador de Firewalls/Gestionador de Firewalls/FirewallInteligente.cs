

namespace GestionadorFirewalls
{
    /// <summary>
    /// Clase que define firewalls inteligentes - hereda del firewall avanzado
    /// </summary>
    public class FirewallInteligente : FirewallAvanzado
    {
        // Atributos
        private int NivelDeInteligencia { get; set; }
        private String LogActividades { get; set; }


        // Constructor
        public FirewallInteligente(String nombre, String tipo, bool estado, String reglas, String modelo, String ipPublica,
            String version, String licencia, String tecnologiasSoportadas, int nivelDeInteligencia, String logActividades) 
            : base(nombre, tipo, estado, reglas, modelo, ipPublica, version, licencia, tecnologiasSoportadas)
        {
            NivelDeInteligencia = nivelDeInteligencia;
            LogActividades = logActividades;
        }

        /// <summary>
        /// Método heredado que sobreescribe al de la base, activa lso firewalls y agrega información específica
        /// </summary>
        public override void Activar()
        {
            base.Activar();
            Console.WriteLine("\nFirewall Inteligente se ha activado" + "\n" +
                "Nivel de Inteligencia: " + NivelDeInteligencia + "\n" + 
                "Log de Actividades: " + LogActividades + "\n");
        }

        /// <summary>
        /// Método que muestra el estado de los firewalls, llama al método definido en la base
        /// </summary>
        public override void MostrarEstado()
        {
            base.MostrarEstado();
            Console.WriteLine(
                "Nivel de Inteligencia: " + NivelDeInteligencia + "\n" +
                "Log de Actividades: " + LogActividades + "\n");
        }

        /// <summary>
        /// Métodoo que analiza el tráfico - indica que ha sido activado
        /// </summary>
        public void AnalizarTrafico()
        {
            Console.WriteLine("El análisis de tráfico ha sido ejecutado");
        }
    }
}
