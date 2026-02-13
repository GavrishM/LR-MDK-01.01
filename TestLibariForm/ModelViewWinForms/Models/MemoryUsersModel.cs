using ModelViewWinForms.Model;
using ModelViewWinForms.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewWinForms.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        private List<User> users_ = new List<User>(); 
        public List<User> Load()
        {
            

            return users_;
        }
        public bool Registration(User user)
        {
            bool result = true;
            int count = users_.Count();
            users_.Add(user);
            if (count >= users_.Count()) 
            { 
                result = false;
            }
            return result;
        }
        public MemoryUsersModel(List<User> users)
        {
            users_ = users;
        }
        public MemoryUsersModel() 
        {
            users_.Add(new User("login1", "pasword1", "name1"));
            users_.Add(new User("login2", "pasword2", "name2"));
            users_.Add(new User("login3", "pasword3", "name3"));
        }
    }
}
