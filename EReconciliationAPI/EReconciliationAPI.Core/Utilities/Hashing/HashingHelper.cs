using System.Security.Cryptography;
using System.Text;

namespace EReconciliationAPI.Core.Utilities.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512() )
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPassowrdHash(string password, byte[] paswordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computeHash.Length; i++)
                {
                    if (computeHash[i] != paswordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
