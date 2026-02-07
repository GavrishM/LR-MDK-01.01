using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    interface IUserInterface
    {
        List<User> Load();
        void Registration(string login, string password);
        void CheckLogin(string login);
    }
}
