using ModelViewWinForms.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewWinForms.Views
{
    public interface IUsersView
    {
        void ShowUsers(List<User> users);

        List<User> GetSelectedUsers();
    }
}
