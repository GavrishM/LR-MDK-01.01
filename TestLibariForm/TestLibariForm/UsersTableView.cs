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
        }
        public List<User> GetSelectedUsers() 
        {
            List<User> result = new List<User>();
            foreach (var row in SelectedRows)
            {
                result.Add(row as User);
            }
            return result;
        }
        public void Remove() 
        {
        
        }
    }
}
