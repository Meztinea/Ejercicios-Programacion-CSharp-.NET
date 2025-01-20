
namespace CifradorMensajes
{
    /// <summary>
    /// Clase para crear cifrado básico - cambia unas letras por otras - algoritmo básico
    /// </summary>
    public class CifradoBasico : Cifrado
    {

        // Constructor
        public CifradoBasico(String mensaje) :base(mensaje)
        {
        }


        // Métodos

        /// <summary>
        /// Método que cifra el mensaje original con un cifrado básico
        /// </summary>
        public override void Cifrar()
        {
            String mensajeOriginal = GetMensajeOriginal();
            String nuevoMensaje = mensajeOriginal;

            // Reemplazando letras para cifrar mensaje
            nuevoMensaje = nuevoMensaje.Replace('a', 'z');
            nuevoMensaje = nuevoMensaje.Replace('e', 'x');
            nuevoMensaje = nuevoMensaje.Replace('i', 'y');
            nuevoMensaje = nuevoMensaje.Replace('o', 'w');
            nuevoMensaje = nuevoMensaje.Replace('u', 'v');
            nuevoMensaje = nuevoMensaje.Replace('A', 'Z');
            nuevoMensaje = nuevoMensaje.Replace('E', 'X');
            nuevoMensaje = nuevoMensaje.Replace('I', 'Y');
            nuevoMensaje = nuevoMensaje.Replace('O', 'W');
            nuevoMensaje = nuevoMensaje.Replace('U', 'V');

            SetMensajeOriginal(nuevoMensaje);
        }

        /// <summary>
        /// Método que realiza un cifrado más seguro, ejecutando el cifrado en varias ocasiones
        /// </summary>
        /// <param name="nivel"> Nivel de cifrado que se desea aplicar </param>
        public void Cifrar(int nivel)
        {
            if (nivel > 1)
            {
                for (int i = 0; i < nivel; i++)
                {
                    Cifrar();
                }
            }
            else
            {
                Cifrar();
            }
        }


        /// <summary>
        /// Método que descifra el mensaje original, lo devuelve a su estado original
        /// </summary>
        public override void Descifrar()
        {
            String mensajeOriginal = GetMensajeOriginal();
            String nuevoMensaje = mensajeOriginal;

            // Reemplazando letras para descifrar mensaje
            nuevoMensaje = nuevoMensaje.Replace('z', 'a');
            nuevoMensaje = nuevoMensaje.Replace('x', 'e');
            nuevoMensaje = nuevoMensaje.Replace('y', 'i');
            nuevoMensaje = nuevoMensaje.Replace('w', 'o');
            nuevoMensaje = nuevoMensaje.Replace('v', 'u');
            nuevoMensaje = nuevoMensaje.Replace('Z', 'A');
            nuevoMensaje = nuevoMensaje.Replace('X', 'E');
            nuevoMensaje = nuevoMensaje.Replace('Y', 'I');
            nuevoMensaje = nuevoMensaje.Replace('W', 'O');
            nuevoMensaje = nuevoMensaje.Replace('V', 'U');

            SetMensajeOriginal(nuevoMensaje);
        }


    }
}
