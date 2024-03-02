using System.Security.Cryptography;
using System.Text;
using idflApp.Constants;

namespace idflApp.Utils
{
    public class HashPasswordUtils
    {
        internal static string DecryptCode(string code)
        {
             if (code != null)
            {
                string encryptionKey = KeyConstant.EncryptionKey;
                byte[] cipherBytes = Convert.FromBase64String(code);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        code = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }

                return code;
            }
            return null;
        }

        internal static string EncryptCode(string code)
        {
            string encryptionKey = KeyConstant.EncryptionKey;
            byte[] clearBytes = Encoding.Unicode.GetBytes(code);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    code = Convert.ToBase64String(ms.ToArray());
                }
            }

            return code;
        }

    }
}