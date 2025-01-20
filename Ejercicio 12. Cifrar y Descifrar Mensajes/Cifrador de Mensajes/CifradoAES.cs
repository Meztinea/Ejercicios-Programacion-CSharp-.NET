using System.Security.Cryptography;
using System.Text;

namespace CifradorMensajes
{
    /// <summary>
    /// Clase que permite crear objetos para cifrar mensajes con cifrado AES
    /// </summary>
    public class CifradoAES : Cifrado
    {

        // Atributos
        private String Clave;
        private byte[] IV;

        // Getters y Setters
        public String GetClave()
        {
            return Clave;
        }

        /// <summary>
        /// Método que permite setear la clave para el cifrado - Verifica que la longitud de cifrado sea correcta
        /// </summary>
        /// <param name="Clave"></param>
        public void SetClave(String Clave)
        {
            if (Clave.Length >=1 && Clave.Length <=16)
            {
                this.Clave = Clave;
            }
            else
            {
                Console.WriteLine("Longitud de la clave incorrecta");
            }
           
        }

        public byte[] GetIV()
        {
            return this.IV;
        }

        public void SetIV(byte[] IV)
        {
            this.IV = IV;
        }

        // Constructor
        public CifradoAES(String mensaje) : base(mensaje)
        {
        }

        /// <summary>
        /// Método que permite cifrar un mensaje por cifrado AES
        /// </summary>
        public override void Cifrar()
        {
            String mensaje = GetMensajeOriginal();
            String clave = GetClave();
            String nuevoMensaje = "";

            byte[] iv;
            byte[] mensajeEnBytes = Encoding.UTF8.GetBytes(mensaje);
            byte[] claveEnBytes = Encoding.UTF8.GetBytes(clave);

            using (Aes aesAlg = Aes.Create())
            {
                iv = aesAlg.IV; // Crea el vector de inicialización
                SetIV(iv); // Almacena el vector para poder descifrar el mensaje

                aesAlg.Key = claveEnBytes;
                aesAlg.IV = iv;

                // Onjeto Cifrador de tipo AES
                ICryptoTransform cifrador = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream mensajeCifrar = new MemoryStream())
                {
                    using (CryptoStream csCrifrar = new CryptoStream(mensajeCifrar, cifrador, CryptoStreamMode.Write))
                    {
                        csCrifrar.Write(mensajeEnBytes, 0, mensajeEnBytes.Length);
                        csCrifrar.FlushFinalBlock();
                    }

                    // Convirtiendo los bytes del mensaje cifrado a un String
                    nuevoMensaje = Convert.ToBase64String(mensajeCifrar.ToArray());
                }
            }

            SetMensajeOriginal(nuevoMensaje);
        }

        /// <summary>
        /// Método para descifrar un mensaje que fue cifrado por AES
        /// </summary>
        public override void Descifrar()
        {
            byte[] textoCifradoBytes = Convert.FromBase64String(GetMensajeOriginal());

            using (Aes aesAlg = Aes.Create())
            {
                
                aesAlg.Key = Encoding.UTF8.GetBytes(this.Clave);
                aesAlg.IV = GetIV();

                // Descifrador del tipo AES
                ICryptoTransform Descifrador = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream mensajeDescifrar = new MemoryStream(textoCifradoBytes))
                {
                    using (CryptoStream csDescifrar = new CryptoStream(mensajeDescifrar, Descifrador, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDescifrar))
                        {
                            
                            // Convierte el mensaje descifrado en un String
                            String nuevoMensaje = srDecrypt.ReadToEnd();
                            SetMensajeOriginal(nuevoMensaje);
                        }
                    }
                }
            }
        }
    }
}
