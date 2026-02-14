using ModelViewWinForms.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewWinForms.Model
{
    public interface IUsersModel
    {
        List<User> Load();

        bool Registration(User user);
        void Remove(List<User> users);
    }
}
