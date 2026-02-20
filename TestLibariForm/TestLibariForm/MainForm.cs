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
    //Доделать кнопку удалить и сделать кнопку добавить(вызывает форму с полями для ввода значений и кнопками Y\N)
    public partial class MainForm: Form
    {
        IUsersModel model_ = new MemoryUsersModel();
        UsersPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new UsersPresenter(new MemoryUsersModel(), UsersTable);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUsers = new List<User>();
            selectedUsers.AddRange(UsersTable.GetSelectedUsers());
            presenter_.Remove(selectedUsers);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Application.Run(new AddUserForm());
        }
    }
}
