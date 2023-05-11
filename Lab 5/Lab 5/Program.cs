using Lab5Lib;
using System;
using System.Formats.Tar;
using System.Security.Cryptography;
using System.Text;

namespace Lab_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab # 5");
            
            {
                IWriter writer = new StrWriter();
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecSHA512(rsa);
                string? result = hash.Save("AAAAABBBBCCCCC");
                Console.WriteLine();
                Console.WriteLine(result);
                Console.WriteLine();

                bool testresult = testSHA512_SA(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 1, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new FileWriter(@"test2.txt");
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecSHA512(rsa);
                string? result = hash.Save("BBBBCCCCC");

                StreamReader reader = new StreamReader(result);
                string? message = reader.ReadLine();
                reader.Close();
                bool testresult = testSHA512_SA(message, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 2, testresult ? "passed" : "NOT passed"));

            }
            {
                IWriter writer = new StrWriter();
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecMD5(rsa);
                string? result = hash.Save("AAAAACCCCBBBBB");

                bool testresult = testMD5_SA(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 3, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new FileWriter(@"test4.txt");
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecMD5(rsa);
                string? result = hash.Save("AAAAABBBBDDDDDCCCCC");

                StreamReader reader = new StreamReader(result);
                string? message = reader.ReadLine();
                bool testresult = testMD5_SA(message, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 4, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new StrWriter();
                IWriter hash = new DecSHA512(writer);
                string? result = hash.Save("AAAAAEEEEEBBBBCCCCC");

                bool testresult = testSHA512(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 5, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new StrWriter();
                IWriter hash = new DecMD5(writer);
                string? result = hash.Save("AAAAABBBBCCCCCHHHH");

                bool testresult = testMD5(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 6, testresult ? "passed" : "NOT passed"));
            }

            {
                IWriter writer = new FileWriter();
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecSHA512(rsa);
                string? result = hash.Save("AAAAABBBBDDDDDCCCCC");

                StreamReader reader = new StreamReader(result);
                string? message = reader.ReadLine();
                bool testresult = testSHA512_SA(message, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 7, testresult ? "passed" : "NOT passed"));
            }



            {
                IWriter writer = new StrWriter();
                IWriter hash = new DecSHA512(writer);
                string? result = hash.Save("AAAAABBBBCCCCC");

                bool testresult = testMD5(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 8, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new StrWriter();
                IWriter hash = new DecSHA512(writer);
                string? result = hash.Save(string.Format("{0}{1}{2}", "AAAAA", Lab5Lib.Constant.Delimiter, "BBBBCCCCC"));  // ðàçäåëèòåëü â òåêñòå

                bool testresult = testSHA512(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 9, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new StrWriter();
                IWriter hash = new DecMD5(writer);
                string? result = hash.Save(string.Format("{0}{1}{2}", "AAAAA", Lab5Lib.Constant.Delimiter, "BBBBCCCCC"));
                bool testresult = testSHA512(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 10, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new StrWriter();
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecMD5(rsa);
                string? result = hash.Save("HHHAAAAABBBBCCCCC");

                bool testresult = testSHA512_SA(result, Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 11, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new FileWriter(@"test12.txt");
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecSHA512(rsa);
                string? result = hash.Save("BBBBCCCCC");


                StreamReader reader = new StreamReader(result);
                string? message = reader.ReadLine();
                bool testresult = testSHA512_SA("BBBBXCCCC", Lab5Lib.Constant.Delimiter);
                Console.WriteLine(string.Format("Test {0} - {1} ", 12, testresult ? "passed" : "NOT passed"));
            }
            {
                IWriter writer = new FileWriter(@"test13.txt");
                IWriter rsa = new DecRSA(writer);
                IWriter hash = new DecMD5(rsa);
                string? result = hash.Save("BBBBCCCCC");

                StreamReader reader = new StreamReader(result);
                string? message = reader.ReadLine();
                bool testresult = testSHA512_SA(message, Lab5Lib.Constant.Delimiter);

                Console.WriteLine(string.Format("Test {0} - {1} ", 13, testresult ? "passed" : "NOT passed"));
            }
        }

        static bool testSHA512(string? message, char delimiter = '\uffff')
        {
            bool rc = false;
            try
            {
                message = message ?? string.Empty;
                int k1 = message.IndexOf(delimiter);
                if (k1 == -1) throw new Exception("delimiter not found");
                string xs = message.Substring(0, k1);
                string xsbhcs = message.Substring(k1 + 1);
                byte[] xsbhc = Convert.FromBase64String(xsbhcs);
                rc = eqSHA512(xs, xsbhc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("testSHA512: {0}", ex.Message));
            }
            return rc;
        }
        static bool testMD5(string? message, char delimiter = '\uffff')
        {
            bool rc = false;
            try
            {
                message = message ?? string.Empty;
                int k1 = message.IndexOf(delimiter);
                if (k1 == -1) throw new Exception("delimiter not found");
                string xs = message.Substring(0, k1);
                string xsbhcs = message.Substring(k1 + 1);
                byte[] xsbhc = Convert.FromBase64String(xsbhcs);
                rc = eqMD5(xs, xsbhc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("testMD5: {0}", ex.Message));
            }
            return rc;

        }
        static bool testSHA512_SA(string? message, char delimiter = '\uffff')
        {
            bool rc = false;
            try
            {
                message = message ?? string.Empty;
                int k1 = message.IndexOf(delimiter);
                int k2 = message.IndexOf(delimiter, k1 + 1);
                if (k1 == -1 || k2 == -1) throw new Exception("delimiter not found");
                string xs = message.Substring(0, k1);
                string xsbhcs = message.Substring(k1 + 1, k2 - k1 - 1);
                string xparam = message.Substring(k2 + 1);
                byte[] xsbh = deRSA(xsbhcs, xparam);
                rc = eqSHA512(xs, xsbh);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("testSHA512_SA: {0}", ex.Message));
            }
            return rc;
        }

        static bool testMD5_SA(string? message, char delimiter = '\uffff')
        {
            bool rc = false;
            try
            {
                message = message ?? string.Empty;
                int k1 = message.IndexOf(delimiter);
                int k2 = message.IndexOf(delimiter, k1 + 1);
                if (k1 == -1 || k2 == -1) throw new Exception("delimiter not found");
                string xs = message.Substring(0, k1);
                string xsbhcs = message.Substring(k1 + 1, k2 - k1 - 1);
                string xparam = message.Substring(k2 + 1);
                byte[] xsbh = deRSA(xsbhcs, xparam);
                rc = eqMD5(xs, xsbh);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("testMD5_SA: {0}", ex.Message));
            }
            return rc;
        }



        static byte[] deRSA(string sbhcs, string xmlparam)
        {
            byte[] rc = { };
            try
            {
                byte[] xsbhc = Convert.FromBase64String(sbhcs);
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(xmlparam);
                    rc = rsa.Decrypt(xsbhc, RSAEncryptionPadding.Pkcs1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("deRSA: {0}", ex.Message));
            }
            return rc;
        }
        static bool eqMD5(string s, byte[] hash)
        {
            bool rc = true;
            s = s ?? string.Empty;
            byte[] sb = Encoding.ASCII.GetBytes(s);
            MD5 md5 = MD5.Create();
            byte[] sbh = md5.ComputeHash(sb);
            rc = sbh.SequenceEqual(hash);
            return rc;
        }

        static bool eqSHA512(string s, byte[] hash)
        {
            bool rc = true;
            s = s ?? string.Empty;
            byte[] sb = Encoding.ASCII.GetBytes(s);
            SHA512 sha512 = SHA512.Create();
            byte[] sbh = sha512.ComputeHash(sb);
            rc = sbh.SequenceEqual(hash);
            return rc;
        }
    }
}
