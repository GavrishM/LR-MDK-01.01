using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    class FileUsersStorage : IUserInterface
    {
        public List<User> Load() 
        {
            List<User> result = new List<User>();
            string path = Path.Combine(Application.StartupPath, "Passwords.txt");
            StreamReader Sr = new StreamReader(path);
            string line;
            while ((line = Sr.ReadLine()) != null)
            {
                string[] UserInformation = line.Split('-');
                User user = new User(UserInformation[0], UserInformation[1]);
                result.Add(user);
            }
            return result;
        }
        public void Registration() 
        {
        
        }
        public void CheckLogin() 
        {
        
        }

    }
}
