using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewWinForms.Models;
using ModelViewWinForms.Presenters;
using ModelViewWinForms.Views;
using ModelViewWinForms.ModelViews;
using ModelViewWinForms.Model;

namespace TestLibariForm
{
    public partial class MainForm: Form
    {
        IUsersModel model_ = new MemoryUsersModel();
        UsersPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();

            UsersPresenter presenter = new UsersPresenter(new MemoryUsersModel(), UsersTable);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUsers = UsersView.GetSelectedUsers;
            presenter_.Remove(selectedUsers);
        }
    }
}
