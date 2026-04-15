using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    internal interface IAUTH
    {
        bool Authenticate(string role, string login, string password);
        bool AuthenticateInstructor(string login, string password);
    }
}
