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
        ////Esta función es para encriptar la clave al REGISTRARSE recibe el String de la clave que introduce el usuario 
        public static string encriptarClaveRegistro(string PassUser)
        {
            int minSaltSize = 4;
            int maxSaltSize = 8;

            // determina el tamaño de la sal
            int saltSize = random.Next(minSaltSize, maxSaltSize);
            byte[] saltBytes = new byte[saltSize];

            // Utiliza un generador seguro de números aleatorios
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Obtiene la sal con el generador
            rng.GetNonZeroBytes(saltBytes);
            

            // Convierte la contraseña a arreglo de bytes
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(PassUser);

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

        //Esta función es para encriptar la clave al LOGUEARSE
        public static string encriptarClaveConexion(string PassUser, string sal)
        {
            // Convierte la sal en array de bytes
            byte[] saltBytes = Convert.FromBase64String(sal);

            // Convierte la contraseña a array de bytes
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(PassUser);

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

            // Copia el hash en el array
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


        //public static bool comprobarClave(string pass, string hash)
        //{
        //    Convierte al hash a arreglo de bytes
        //    byte[] hashWithSaltBytes = Convert.FromBase64String(hash);

        //    Tamaño del hash en bits
        //    int hashSizeInBits, hashSizeInBytes;
        //    hashSizeInBits = 512;

        //    Convierte el tamaño a bytes
        //   hashSizeInBytes = hashSizeInBits / 8;

        //    Verifica que el valor es lo suficientemente largo
        //    if (hashWithSaltBytes.Length < hashSizeInBytes)
        //        return false;

        //    Arreglo para almacenar la sal
        //    byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

        //    Copia la sal al arreglo
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
        //    }

        //    Calcula de nuevo el hash
        //    string expectedHashString = encriptarClaveRegistro(pass, saltBytes);

        //    Si ambos hash coinciden la contraseña es correcta
        //    return (hash == expectedHashString);
        //}
        //public static bool comprobarClave2(string pass, string hash)
        //{
        //    if (pass.Equals(hash))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //    Convierte al hash a arreglo de bytes
        //    byte[] hashWithSaltBytes = Convert.FromBase64String(hash);
        //    byte[] hashWithSaltBytes2 = Convert.FromBase64String(pass);

        //    Console.WriteLine(hashWithSaltBytes);
        //    Console.WriteLine(hashWithSaltBytes2);

        //    Tamaño del hash en bits
        //    int hashSizeInBits, hashSizeInBytes;
        //    int hashSizeInBits2, hashSizeInBytes2;
        //    hashSizeInBits = 512;
        //    hashSizeInBits2 = 512;
        //    Convierte el tamaño a bytes
        //   hashSizeInBytes = hashSizeInBits / 8;
        //    hashSizeInBytes2 = hashSizeInBits2 / 8;

        //    Verifica que el valor es lo suficientemente largo
        //    if (hashWithSaltBytes.Length < hashSizeInBytes && hashWithSaltBytes2.Length < hashSizeInBytes2)
        //        return false;

        //    Arreglo para almacenar la sal
        //    byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];
        //    byte[] passInBytes = new Byte[hashSizeInBytes2];

        //    for (int i = 0; i < passInBytes.Length; i++)
        //    {
        //        passInBytes[i] = hashWithSaltBytes[i];
        //    }
        //    Copia la sal al arreglo
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
        //    }

        //    Calcula de nuevo el hash
        //    string expectedHashString = agregarSal(passInBytes, saltBytes);

        //    Si ambos hash coinciden la contraseña es correcta
        //    return (hash == expectedHashString);
        //}

        //public static string agregarSal(byte[] passUserInBytes, byte[] saltBytes = null)
        //{

        //    Convierte la contraseña a arreglo de bytes
        //    byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(PassUser);

        //    Arreglo para guardar la contraseña y la sal
        //    byte[] plainTextWithSaltBytes = new byte[passUserInBytes.Length + saltBytes.Length];

        //    Almacena la contraseña
        //    for (int i = 0; i < passUserInBytes.Length; i++)
        //    {
        //        plainTextWithSaltBytes[i] = passUserInBytes[i];
        //    }

        //    Añade la sal
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        plainTextWithSaltBytes[passUserInBytes.Length + i] = saltBytes[i];
        //    }

        //    Especifica el algoritmo SHA512
        //    HashAlgorithm hash = new SHA512Managed();

        //    Calcula el hash
        //    byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

        //    Arreglo para almacenar el hash y la sal
        //    byte[] hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

        //    Copia el hash en el arreglo
        //    for (int i = 0; i < hashBytes.Length; i++)
        //    {
        //        hashWithSaltBytes[i] = hashBytes[i];
        //    }

        //    Añade la sal
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
        //    }

        //    Convierte el resultado a cadena y lo devuelve
        //    return Convert.ToBase64String(hashWithSaltBytes);

        //}



        //public static string getSal(string hash)
        //{
        //    Convierte al hash a arreglo de bytes
        //    byte[] hashWithSaltBytes = Convert.FromBase64String(hash);

        //    Tamaño del hash en bits
        //    int hashSizeInBits, hashSizeInBytes;
        //    hashSizeInBits = 512;

        //    Convierte el tamaño a bytes
        //   hashSizeInBytes = hashSizeInBits / 8;

        //    Verifica que el valor es lo suficientemente largo
        //    if (hashWithSaltBytes.Length < hashSizeInBytes)
        //        return null;

        //    Arreglo para almacenar la sal
        //    byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

        //    Copia la sal al arreglo
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
        //    }

        //    return Convert.ToBase64String(saltBytes);

        //    return saltBytes;
        //}

        
        //    //Fución de encriptación original
        //public static string encriptarClaveOriginal(string PassUser, byte[] saltBytes = null)
        //{
        //    if (saltBytes == null)
        //    {
        //        int minSaltSize = 4;
        //        int maxSaltSize = 8;

        //        // determina el tamaño de la sal
        //        int saltSize = random.Next(minSaltSize, maxSaltSize);
        //        saltBytes = new byte[saltSize];

        //        // Utiliza un generador seguro de números aleatorios
        //        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        //        // Obtiene la sal con el generador
        //        rng.GetNonZeroBytes(saltBytes);
        //    }

        //    // Convierte la contraseña a arreglo de bytes
        //    byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(PassUser);

        //    // Arreglo para guardar la contraseña y la sal
        //    byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];

        //    // Almacena la contraseña
        //    for (int i = 0; i < plainTextBytes.Length; i++)
        //    {
        //        plainTextWithSaltBytes[i] = plainTextBytes[i];
        //    }

        //    // Añade la sal
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
        //    }

        //    // Especifica el algoritmo SHA512
        //    HashAlgorithm hash = new SHA512Managed();

        //    // Calcula el hash
        //    byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

        //    // Arreglo para almacenar el hash y la sal
        //    byte[] hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

        //    // Copia el hash en el arreglo
        //    for (int i = 0; i < hashBytes.Length; i++)
        //    {
        //        hashWithSaltBytes[i] = hashBytes[i];
        //    }

        //    // Añade la sal
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
        //    }

        //    // Convierte el resultado a cadena y lo devuelve
        //    return Convert.ToBase64String(hashWithSaltBytes);
        //}
    }
}
