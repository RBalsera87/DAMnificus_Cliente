using System;
using System.Security.Cryptography;

namespace Proyecto_AccesoDatos
{
    public class Clave
    {
        public Clave()
        {

        }
        private static readonly Random random = new Random();
        //Recibe el String de la clave que introduce el usuario (Sería para cuando se registre)
        public static string EncriptarClave(string plainText, byte[] saltBytes = null)
        {
            if (saltBytes == null)
            {
                int minSaltSize = 4;
                int maxSaltSize = 8;

                // determina el tamaño de la sal
                int saltSize = random.Next(minSaltSize, maxSaltSize);
                saltBytes = new byte[saltSize];

                // Utiliza un generador seguro de números aleatorios
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                // Obtiene la sal con el generador
                rng.GetNonZeroBytes(saltBytes);
            }

            // Convierte la contraseña a arreglo de bytes
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);

            // Arreglo para guardar la contraseña y la sal
            byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];

            // Almacena la contraseña
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextBytes[i];
            }

            // Añade la sal
            for (int i = 0; i < saltBytes.Length; i++)
            {
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }

            // Especifica el algoritmo SHA512
            HashAlgorithm hash = new SHA512Managed();

            // Calcula el hash
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Arreglo para almacenar el hash y la sal
            byte[] hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

            // Copia el hash en el arreglo
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashWithSaltBytes[i] = hashBytes[i];
            }

            // Añade la sal
            for (int i = 0; i < saltBytes.Length; i++)
            {
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }

            // Convierte el resultado a cadena y lo devuelve
            return Convert.ToBase64String(hashWithSaltBytes);
        }

        //Recibe el String de la clave que introduce el usuario y la clave encriptada de la base de datos
        public static bool ComprobarClave(string pass, string hash)
        {
            // Convierte al hash a arreglo de bytes
            byte[] hashWithSaltBytes = Convert.FromBase64String(hash);

            // Tamaño del hash en bits
            int hashSizeInBits, hashSizeInBytes;
            hashSizeInBits = 512;

            // Convierte el tamaño a bytes
            hashSizeInBytes = hashSizeInBits / 8;

            // Verifica que el valor es lo suficientemente largo
            if (hashWithSaltBytes.Length < hashSizeInBytes)
                return false;

            // Arreglo para almacenar la sal
            byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

            // Copia la sal al arreglo
            for (int i = 0; i < saltBytes.Length; i++)
            {
                saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
            }

            // Calcula de nuevo el hash
            string expectedHashString = EncriptarClave(pass, saltBytes);

            // Si ambos hash coinciden la contraseña es correcta
            return (hash == expectedHashString);
        }
    }
}
