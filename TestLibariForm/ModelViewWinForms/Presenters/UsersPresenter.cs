using ModelViewWinForms.Model;
using ModelViewWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewWinForms.Presenters
{
    public class UsersPresenter
    {
        private IUsersModel model_;
        private IUsersView view_;
        public UsersPresenter(IUsersModel modelInterface, IUsersView viewInterface)
        {
            model_ = modelInterface;
            view_ = viewInterface;

            view_.ShowUsers(model_.Load());
        }
       
    }
}
