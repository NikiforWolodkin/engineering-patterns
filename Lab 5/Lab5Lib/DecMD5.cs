using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Lib
{
    public class DecMD5 : Decorator
    {
        public DecMD5(IWriter writer) : base(writer) { }

        public override string? Save(string? message)
        {
            using (var md5 = MD5.Create())
            {
                var dataBytes = Encoding.UTF8.GetBytes(message);

                var encryptedData = md5.ComputeHash(dataBytes);

                var hashedMessage = Convert.ToBase64String(encryptedData);

                return _writer?.Save($"{message}{Constant.Delimiter}{hashedMessage}");
            }
        }
    }
}
