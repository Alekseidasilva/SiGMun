﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace SiGMun.Helpers.Cripto
{
    
    public  class Criptografar
    {
        private const string AesIV256 = @"AlekseidaSilva15";
        private const string AesKey256 = @"AlekseiJustinoMateusDondodaSilva";
        public static string Encriptar(string text)
        {
            // AesCryptoServiceProvider
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.IV = Encoding.UTF8.GetBytes(AesIV256);
            aes.Key = Encoding.UTF8.GetBytes(AesKey256);
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            // Convert string to byte array
            byte[] src = Encoding.Unicode.GetBytes(text);

            // encryption
            using (ICryptoTransform encrypt = aes.CreateEncryptor())
            {
                byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);

                // Convert byte array to Base64 strings
                return Convert.ToBase64String(dest);
            }
        }
    }
}