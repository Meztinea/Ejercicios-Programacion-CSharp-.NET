
namespace GestionadorFirewalls
{
    /// <summary>
    /// Clase base - Clase padre
    /// </summary>
    public class Firewall
    {
        // Atributos
        private String Nombre { get; set; }
        private String Tipo { get; set; }
        private bool Estado { get; set; }
        private String Reglas { get; set; }


        // Constuctor 
        public Firewall(String nombre, String tipo, bool estado, String reglas)
        {
            Nombre = nombre;
            Tipo = tipo;
            Estado = estado;
            Reglas = reglas;
        }


        /// <summary>
        /// Método que activa el firewall
        /// </summary>
        public virtual void Activar()
        {
            this.Estado = true; 
        }

        /// <summary>
        /// Método que desactiva el firewall
        /// </summary>
        public virtual void Desactivar()
        {
            this.Estado = false;
            Console.WriteLine("Firewall Desactivado: " + Nombre);
        }

        /// <summary>
        /// Método que agrega una nueva regla a las reglas del firewall
        /// </summary>
        /// <param name="regla"> Nueva regla para agregar a las reglas existentes </param>
        public void AgregarRegla(String regla)
        {
            this.Reglas = this.Reglas + regla + ", ";
            Console.WriteLine("Regla agregada con éxito. ");
        }

        /// <summary>
        /// Método que muestra la información del firewall 
        /// </summary>
        public virtual void MostrarEstado()
        {
            Console.WriteLine(
                "\n*** Información del Firewall ***\n" + 
                "Nombre: " + Nombre + "\n" + 
                "Tipo: " + Tipo + "\n" + 
                "Estado: " + Estado + "\n" + 
                "Reglas: " + Reglas + "\n");
        }
    }
}
