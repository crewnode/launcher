using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CrewNode.Updater.Utils
{
    internal enum HashType
    {
        MD5,
        SHA1,
        SHA512
    };

    internal static class Hasher
    {
        internal static string HashFile(string filePath, HashType algorithm)
        {
            switch (algorithm)
            {
                case HashType.MD5:
                    return MakeHashString(MD5.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                case HashType.SHA1:
                    return MakeHashString(SHA1.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                case HashType.SHA512:
                    return MakeHashString(SHA512.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                default:
                    return "";
            }
        }

        private static string MakeHashString(byte[] hashStr)
        {
            StringBuilder s = new StringBuilder(hashStr.Length * 2);
            foreach (byte b in hashStr)
                s.Append(b.ToString("X2").ToLower());
            return s.ToString();
        }
    }
}
