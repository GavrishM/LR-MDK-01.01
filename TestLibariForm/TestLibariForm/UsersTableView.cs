using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewWinForms.ModelViews;
using ModelViewWinForms.Views;

namespace TestLibariForm
{
    public class UsersTableView : DataGridView, IUsersView
    {
        public void ShowUsers(List<User> users)
        {
            DataSource = users;
            /*
            string temp; //Переменная временно заменяющая таблицу
            int index = 0;
            foreach(User user in users)
            {
                temp = user.Login;
                temp = user.Pasword;
                temp = user.Name;
                index++;
            }
            */
        }
    }
}
