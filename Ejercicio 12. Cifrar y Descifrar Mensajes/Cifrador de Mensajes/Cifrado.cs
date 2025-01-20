

namespace CifradorMensajes
{
    /// <summary>
    /// Clase base Cifrado para especializar a otras clases por tipo de cifrado
    /// </summary>
    public class Cifrado
    {
        // Atributos
        private String MensajeOriginal;


        // Getters y Setters
        public String GetMensajeOriginal()
        {
            return MensajeOriginal;
        }
        
        public void SetMensajeOriginal(String Mensaje)
        {
            this.MensajeOriginal = Mensaje;
        }
        

        // Constructor
        public Cifrado(String mensaje)
        {
            this.MensajeOriginal= mensaje;
        }


        // Métodos
        public virtual void Cifrar()
        {
        }

        public virtual void Descifrar()
        {
        }

    }
}
