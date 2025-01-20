
namespace CifradorMensajes
{
    /// <summary>
    /// Clase para crear objetos que se cifran por desplazamiento
    /// </summary>
    public class CifradoPorDesplazamiento : CifradoBasico
    {
        // Atributos
        private int Desplazamiento;

        // Getters y Setters
        public int GetDesplazamiento()
        {
            return Desplazamiento;
        }
        /// <summary>
        /// Método que inicializa el valor del desplazamiento - verifica que se encuentre entre los valores permitidos
        /// </summary>
        /// <param name="desplazamiento"> Número que representa el desplazamiento en el alfabeto para cifrar </param>
        public void SetDesplazamiento(int desplazamiento)
        {
            if(desplazamiento >= 1 && desplazamiento <= 25)
            {
                this.Desplazamiento = desplazamiento;
            }
            else
            {
                Console.WriteLine("El desplezamiento debe ser un valor entero entre 1 y 25");
            }
        }


        // Constructor
        public CifradoPorDesplazamiento(String mensaje) : base(mensaje)
        {
        }

        // Métodos

        /// <summary>
        /// Método que cifra el mensaje utilizando el tipo Cesar
        /// </summary>
        public override void Cifrar()
        {
            if(this.Desplazamiento != 0)
            {
                String mensaje = GetMensajeOriginal();
                int desplazamiento = GetDesplazamiento();

                char[] mensajeCifrado = new char[mensaje.Length];

                for (int i = 0; i < mensaje.Length; i++)
                {
                    char c = mensaje[i];

                    if (char.IsLetter(c)) // Verifica que el carácter sea una letra
                    {
                        char baseLetra = char.IsUpper(c) ? 'A' : 'a'; // Para saber si es mayúscula o minúscula
                        int nuevaPosicion = (c - baseLetra + desplazamiento) % 26; // Cálculo de la nueva posición en el alfabeto
                        mensajeCifrado[i] = (char)(baseLetra + nuevaPosicion); // Convirtiendo de nuevo a carácter
                    }
                    else
                    {
                        // En caso de no ser letra - no se cifra
                        mensajeCifrado[i] = c;
                    }
                }

                SetMensajeOriginal(new String (mensajeCifrado));
            }
            else
            {
                Console.WriteLine("El desplazamiento no ha sido configurado correctamente.");
            }
        }


        /// <summary>
        /// Método que permite decifrar un mensaje que tiene cifrado tipo Cesar
        /// </summary>
        public override void Descifrar()
        {
            String mensaje = GetMensajeOriginal();
            int desplazamiento = GetDesplazamiento();

            char[] mensajeDesCifrado = new char[mensaje.Length];

            for (int i = 0; i < mensaje.Length; i++)
            {
                char c = mensaje[i];

                if (char.IsLetter(c)) // Verifica que el carácter sea una letra
                {
                    char baseLetra = char.IsUpper(c) ? 'A' : 'a'; // Para saber si es mayúscula o minúscula
                    int nuevaPosicion = (c - baseLetra - desplazamiento + 26) % 26; // Cálculo de la nueva posición en el alfabeto
                    mensajeDesCifrado[i] = (char)(baseLetra + nuevaPosicion); // Convirtiendo de nuevo a carácter
                }
                else
                {
                    // En caso de no ser letra - no se cifra
                    mensajeDesCifrado[i] = c;
                }
            }

            SetMensajeOriginal(new String(mensajeDesCifrado));
        }
    }
}
