using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAndSalt
{
    class Program
    {
        static void Main(string[] args)
        {
            string hash, salt;
            const string password = "!~)(InYourThighs712";

            PasswordHash.CreateHash(password, out hash, out salt);

            Console.WriteLine(hash);
            Console.WriteLine(salt);
            Console.WriteLine(PasswordHash.ValidatePassword(password,hash));
            Console.ReadLine();
        }
    }
}
