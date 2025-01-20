
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace CifradorMensajes
{
    /// <summary>
    /// Clase para crear objetos de cifrado doble - Ejecuta doble cifrado de tipo AES
    /// </summary>
    public class CifradoDoble : CifradoAES
    {
        // Atributos
        private String ClaveSecundaria;

        // Getters y Setters
        public String GetClaveSecundaria()
        {
            return ClaveSecundaria;
        }

        /// <summary>
        /// Método que setea el valor de la clave secundaria - Verifica que las longitudes sean iguales
        /// </summary>
        /// <param name="ClaveSecundaria"> Clave secundaria, necesaria para un cifrado doble </param>
        public void SetClaveSecundaria(String ClaveSecundaria)
        {
            String clave = GetClave();
            if (ClaveSecundaria.Length == clave.Length)
            {
                this.ClaveSecundaria = ClaveSecundaria;
            }
            else
            {
                Console.WriteLine("La longitud de la clave secundaria debe ser igual al de la primera clave");
            }
        }

        // Constructor
        public CifradoDoble(String mensaje) : base(mensaje)
        {
            SetIV(new byte[] {0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10 }); 
        }

        /// <summary>
        /// Método que permite cifrar doblemente un mensaje por el método AES
        /// </summary>
        /// <typeparam name="T"> Tipo Genérico para aceptar byte[] y String </typeparam>
        /// <param name="mensaje"> Mensaje de tipo byte[] o String que se desea cifrar </param>
        public void Cifrar<T>(T mensaje)
        {
            byte[] clavePrincipal = Encoding.UTF8.GetBytes(GetClave());
            byte[] claveSecundaria = Encoding.UTF8.GetBytes(GetClaveSecundaria());

            byte[] mensajeBytes = Array.Empty<byte>();

            // Tratando el mensaje para saber si es String o byte[]
            if (mensaje is string)
            {
                mensajeBytes = Encoding.UTF8.GetBytes(mensaje as string);
            }
            else if (mensaje is byte[])
            {
                mensajeBytes = mensaje as byte[];
            }

            // Primer  cifrado con la clave principal
            byte[] cifradoPrincipal = CifrarAES(mensajeBytes, clavePrincipal);

            // Segundo cifrado con la clave secundaria
            byte[] cifradoSecundario = CifrarAES(cifradoPrincipal, claveSecundaria);

            SetMensajeOriginal(Convert.ToBase64String(cifradoSecundario));

        }

        /// <summary>
        /// Método que ejecuta un cifrado de tipo AES
        /// </summary>
        /// <param name="mensajeEnBytes"> Mensaje en formato de arreglo de bytes [] que se cifrará </param>
        /// <param name="clave"> Clave para cifrar el mensaje por el método AES </param>
        /// <returns></returns>
        public byte[] CifrarAES(byte[] mensajeEnBytes, byte[] clave)
        {
            byte[] nuevoMensaje;

            using (Aes aesAlg = Aes.Create())
            {

                aesAlg.IV = GetIV();
                aesAlg.Key = clave;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;
                String MiIV = Encoding.UTF8.GetString(GetIV());
                Console.WriteLine(MiIV);

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
                    nuevoMensaje = mensajeCifrar.ToArray();
                }
            }

            return nuevoMensaje;
        }

        /// <summary>
        /// Método que permite descifrar doblemente un mensaje por el método AES
        /// </summary>
        public override void Descifrar()
        {
            String mensajeCifrado = GetMensajeOriginal();
            byte[] clavePrincipal = Encoding.UTF8.GetBytes(GetClave());
            byte[] claveSecundaria = Encoding.UTF8.GetBytes(GetClaveSecundaria());

            byte[] mensajeenBytes = Encoding.UTF8.GetBytes(mensajeCifrado);

            // Primer descifrado con la clave principal
            byte[] primerDescifrado = DescifrarAES(mensajeenBytes, clavePrincipal);

            // Segundo descifrado con la clave secundaria
            byte[] segundoDescifrado = DescifrarAES(primerDescifrado, claveSecundaria);

            SetMensajeOriginal(Encoding.UTF8.GetString(segundoDescifrado)); ;

        }

        /// <summary>
        /// Método que ejecuta un descifrado del método AES
        /// </summary>
        /// <param name="mensajeCifrado">  Mensaje para descifrrar </param>
        /// <param name="clave"> Clave para descifrar </param>
        /// <returns></returns>
        private byte[] DescifrarAES(byte[] mensajeCifrado, byte[] clave)
        {

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = clave;
                aesAlg.IV = GetIV();
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                // Descifrador del tipo AES
                ICryptoTransform Descifrador = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream mensajeDescifrar = new MemoryStream(mensajeCifrado))
                {
                    using (CryptoStream csDescifrar = new CryptoStream(mensajeDescifrar, Descifrador, CryptoStreamMode.Read))
                    {
                        using (MemoryStream msResultado = new MemoryStream())
                        {
                            byte[] buffer = new byte[1024];
                            int read;

                            while ((read = csDescifrar.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                msResultado.Write(buffer, 0, read);
                            }

                            // Retorna el mensaje descifrado en formato de arreglo de bytes
                            byte[] data = msResultado.ToArray();
                            int padding = data[data.Length - 1];
                            Array.Resize(ref data, data.Length - padding);

                            return data;
                        }
                    }
                }
            }
        }
    }
}
