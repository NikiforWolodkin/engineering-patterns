using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Lab5Lib
{
    public class DecRSA : Decorator
    {
        public DecRSA(IWriter writer) : base(writer) { }

        public override string? Save(string? message)
        {
            using (var rsa = RSA.Create())
            {
                var dataBytes = Encoding.UTF8.GetBytes(message);

                var encryptedData = rsa.Encrypt(dataBytes, RSAEncryptionPadding.Pkcs1);

                var encryptedMessage = Convert.ToBase64String(encryptedData);
                var publicKey = rsa.ToXmlString(false);

                return _writer?.Save($"{message}{Constant.Delimiter}{encryptedMessage}{Constant.Delimiter}{publicKey}");
            }
        }
    }
}
