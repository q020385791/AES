using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PinTechLib
{
	public static class AES
	{
		public static  string AESEncrypt(string input)
		{
			string key = "3883136338831363";
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(key);
				aesAlg.Mode = CipherMode.ECB;
				aesAlg.Padding = PaddingMode.PKCS7;

				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				byte[] encryptedBytes;
				using (MemoryStream msEncrypt = new MemoryStream())
				{
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
			string key = "3883136338831363";
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(key);
				aesAlg.Mode = CipherMode.ECB;
				aesAlg.Padding = PaddingMode.PKCS7;

				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

				string modifiedInput = input.Replace('-', '+').Replace('_', '/');
				int padding = modifiedInput.Length % 4;
				if (padding > 0)
				{
					modifiedInput = modifiedInput.PadRight(modifiedInput.Length + (4 - padding), '=');
				}
				byte[] inputBytes = Convert.FromBase64String(modifiedInput);
				string decryptedText;
				using (MemoryStream msDecrypt = new MemoryStream(inputBytes))
				{
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							decryptedText = srDecrypt.ReadToEnd();
						}
					}
				}
				return decryptedText;
			}
		}
	}
}
