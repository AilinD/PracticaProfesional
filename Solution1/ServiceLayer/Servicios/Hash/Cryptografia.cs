using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Servicios.Criptografía
{
    public static class Cryptografia
    {
        public static string Hash(string word)
            {
             StringBuilder sb = new StringBuilder();

             using (MD5 md5 = MD5.Create())
              {
                 byte[] retVal = md5.ComputeHash(Encoding.Unicode.GetBytes(word));
                  for (int i = 0; i < retVal.Length; i++)
                  {
                     sb.Append(retVal[i].ToString("x2"));
                  }
             }
             return sb.ToString();
        }

            // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
            // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
            private const string initVector = "pemgail9uzpgzl88";
            // This constant is used to determine the keysize of the encryption algorithm
            private const int keysize = 256;
            //Encrypt
            public static string EncryptString(string plainText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return Convert.ToBase64String(cipherTextBytes);
            }

        //public static string DecryptString(string cipherText, string passPhrase)
        //{
        ////byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
        ////byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
        ////PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
        ////byte[] keyBytes = password.GetBytes(keysize / 8);
        ////RijndaelManaged symmetricKey = new RijndaelManaged();
        ////symmetricKey.Mode = CipherMode.CBC;
        ////ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
        ////MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
        ////CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
        ////byte[] plainTextBytes = new byte[cipherTextBytes.Length];
        ////int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
        ////memoryStream.Close();
        ////cryptoStream.Close();
        ////return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        //try
        //{
        //    byte[] data = Convert.FromBase64String(cipherText);
        //    MD5 md5 = MD5.Create();
        //    TripleDES tripleDES = TripleDES.Create();
        //    tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(passPhrase));
        //    tripleDES.Mode = CipherMode.ECB;
        //    ICryptoTransform cryptoTransform = tripleDES.CreateDecryptor();
        //    byte[] RESULT = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
        //    return UTF8Encoding.UTF8.GetString(RESULT);
        //}
        //catch (CryptographicException ex)
        //{
        //    throw ex;
        //}


        //}

        //public static string Decrypt(string Message, string Passphrase, byte[] iv)
        //{
        //    byte[] Results;
        //    System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
        //    MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
        //    byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(GetSHA256String(Passphrase)));
        //    TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
        //    TDESAlgorithm.Key = TDESKey;
        //    // Apply the same IV used during encryption
        //    TDESAlgorithm.IV = iv;
        //    TDESAlgorithm.Mode = CipherMode.ECB;
        //    TDESAlgorithm.Padding = PaddingMode.PKCS7;
        //    try
        //    {
        //        byte[] DataToDecrypt = Convert.FromBase64String(Message);
        //        //byte[] DataToDecrypt = UTF8.GetBytes(Message);
        //        //byte[] DataToDecrypt = Encoding.UTF8.GetBytes(Message);
        //        ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
        //        Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length); // << ERROR is here.
        //    }
        //    finally
        //    {
        //        TDESAlgorithm.Clear();
        //        HashProvider.Clear();
        //    }
        //    return UTF8.GetString(Results);
        //}

    }
}
