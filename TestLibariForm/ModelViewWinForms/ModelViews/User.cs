using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewWinForms.ModelViews
{
    public class User
    {
        public string Login { get; set;}
        public string Pasword { get; set; }
        public string Name { get; set; }
        
        public User(string login, string pasword, string name )
        { 
            Login = login;
            Pasword = pasword;
            Name = name;
        }
    }
}
