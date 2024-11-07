using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanLib
{
    public static class AES
    {
        private static readonly string key = "3883136338831363";

        public static string AESEncrypt(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;
                aesAlg.GenerateIV(); // 隨機生成 IV

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedBytes;
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // 把 IV 寫到密文的前面
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);

                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(input);
                        }
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }

                return Convert.ToBase64String(encryptedBytes)
                    .Replace('+', '-')
                    .Replace('/', '_')
                    .TrimEnd('=');
            }
        }



        public static string AESDecrypt(string input)
        {
            string modifiedInput = input.Replace('-', '+').Replace('_', '/');
            int padding = modifiedInput.Length % 4;
            if (padding > 0)
            {
                modifiedInput = modifiedInput.PadRight(modifiedInput.Length + (4 - padding), '=');
            }

            byte[] inputBytes = Convert.FromBase64String(modifiedInput);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                // 讀取 IV（假設 IV 存在於密文的前 16 字節）
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                Array.Copy(inputBytes, 0, iv, 0, iv.Length);
                aesAlg.IV = iv;

                // 移除 IV 後的真正密文
                byte[] actualCipherText = new byte[inputBytes.Length - iv.Length];
                Array.Copy(inputBytes, iv.Length, actualCipherText, 0, actualCipherText.Length);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(actualCipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
