using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UDP_UI.Modules
{
    public static class Encryption
    {
        public class AesModule
        {
            public string outgoingKey { get; set; }
            public string incomingKey { get; set; }
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

            public void setEncryptKey(byte[] key) {
                _encrypt.Key = key;
            }

            public void setDecryptKey(byte[] key) {
                _decrypt.Key = key;
            }

            public byte[] encryptOutgoing(string text)
            {
                _encrypt.GenerateIV();
                byte[] buff;
                using(var encryptor = _encrypt.CreateEncryptor()){
                    using (var memStream = new MemoryStream()) {
                        using (var csEncrypt = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write)) {
                            using (var bw = new BinaryWriter(csEncrypt, Encoding.UTF8))
                            {
                                bw.Write(text);
                                bw.Close();
                                buff = memStream.ToArray();
                                return _encrypt.IV.Concat(buff).ToArray();
                            }
                        }
                    }
                }
            }
        }
    }
}
