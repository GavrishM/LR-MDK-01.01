using SalesLibrary.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary.Models
{
    public class Init
    {
        private SalesPresenter presenter_;
        Init(SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        //void FillCartesianChart()
        //{
        //    ItemsList.DataSource = presenter_.GetAllItems();
        //    ItemsList.DisplayMember = "Name";
        //    if (ItemsList.Items.Count > 0)
        //    {
        //        presenter_.ShowSalesByItem(((Item)ItemsList.Items[0]).Name);
        //    }
        //}


    }
}
