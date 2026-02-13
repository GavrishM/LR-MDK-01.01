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

namespace TestLibariForm
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            UsersTableView usersTable = new UsersTableView();
            usersTable.Dock = DockStyle.Top;
            Controls.Add(usersTable);
            UserPresenter presenter = new UserPresenter(new MemoryUsersModel(), usersTable);
        }
    }
}
