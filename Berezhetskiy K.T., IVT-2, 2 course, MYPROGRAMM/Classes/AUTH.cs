using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    internal class AUTH: IAUTH
    {
        private readonly string instructorsFile = "instructors.txt";
        private const string AdminLogin = "Login";
        private const string AdminPassword = "Password";
        public bool Authenticate(string role, string login, string password)
        {
            if (role == "Администратор")
            {
                return login == AdminLogin && password == AdminPassword;
            }

            if (role == "Инструктор")
            {
                return AuthenticateInstructor(login, password);
            }

            return false;
        }

        public bool AuthenticateInstructor(string login, string password)
        {
            if (!File.Exists(instructorsFile))
                return false;

            foreach (var line in File.ReadAllLines(instructorsFile))
            {
                var parts = line.Split(':');
                if (parts.Length == 2 &&
                    parts[0] == login &&
                    parts[1] == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
