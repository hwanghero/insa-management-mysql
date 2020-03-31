using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace project.user
{
    class Hash
    {
        public string EncryptSHA512(string Data)
        {
            SHA512 sha = new SHA512Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Data));
            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }
    }
}
