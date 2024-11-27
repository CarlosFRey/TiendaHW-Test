using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace DTO
{
    public class Encriptar
    {

        public static string GenerateSHA256(string textoplano)
        {
            // Convertir el texto de entrada a un arreglo de bytes
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(textoplano);

                // Calcular el hash SHA256
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convertir el arreglo de bytes a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // "x2" para formato hexadecimal de dos dígitos
                }
                return sb.ToString();
            }
        }
    }
}
