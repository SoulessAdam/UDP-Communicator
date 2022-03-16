using System.Security.Cryptography;
using System.Text;

namespace UDP_UI.Modules
{
    public static class Encryption
    {
        public class AesModule
        {
            private Aes _decrypt = Aes.Create();
            private Aes _encrypt = Aes.Create();

            public AesModule()
            {
                _decrypt.Mode = CipherMode.CFB;
                _encrypt.Mode = CipherMode.CFB;
                _decrypt.Padding = PaddingMode.PKCS7;
                _encrypt.Padding = PaddingMode.PKCS7;
                _decrypt.KeySize = 128;
                _encrypt.KeySize = 128;
            }

            public void setEncryptKey(byte[] key)
            {
                _encrypt.Key = key;
            }

            public void setDecryptKey(byte[] key)
            {
                _decrypt.Key = key;
            }

            public string encryptOutgoing(string text)
            {
                _encrypt.GenerateIV();
                byte[] buff;
                using (var encryptor = _encrypt.CreateEncryptor())
                {
                    using (var memStream = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (var bw = new BinaryWriter(csEncrypt, Encoding.UTF8))
                            {
                                bw.Write(text);
                                bw.Close();
                                buff = memStream.ToArray();

                            }
                        }
                    }
                }
                return $"{Convert.ToBase64String(_encrypt.IV)}*{Convert.ToBase64String(buff)}";
            }

            public string decryptIncoming(string IVCipher_Base64)
            {
                string[] parsed = parseBase64(IVCipher_Base64);
                string IV_Base64 = parsed[0];
                string Cipher_Base64 = parsed[1];
                byte[] IV = System.Convert.FromBase64String(IV_Base64);
                byte[] Cipher = System.Convert.FromBase64String(Cipher_Base64);
                _decrypt.IV = IV;

                string output;
                using (var decryptor = _decrypt.CreateDecryptor())
                {
                    using (MemoryStream ms = new MemoryStream(Cipher))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                output = sr.ReadToEnd();
                            }
                        }
                    }
                }
                return output.TrimStart();
            }

            public string[] parseBase64(string b64)
            {
                var sides = b64.Split("*");
                var IV = sides[0];
                var Cipher = sides[1];
                return new string[] { IV, Cipher };
            }

            
            
        }
    }
}
