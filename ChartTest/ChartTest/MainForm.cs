using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {
        private SalesPresenter presenter_;
        void FillCartesianChart()
        {
            ItemsList.DataSource = presenter_.GetAllItems();
            ItemsList.DisplayMember = "Name";
            if (ItemsList.Items.Count > 0)
            {
                presenter_.ShowSalesByItem(((Item)ItemsList.Items[0]).Name);
            }
        }

        void FillAngular()
        {
            angular.FromValue = 0;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.Gray;
            angular.NeedleFill = Brushes.DarkBlue;
        }

        void FillSolid()
        {
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
        }
        void FillPie()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection();
            double price;
            int temp;
            List<Item> items = presenter_.GetAllItems();
            foreach (Item item in items)
            {
                temp = Convert.ToInt32(ProfitAnalyzer.CalculateProfitPercentByItem(item.Name, presenter_.GetModel()) * 100);
                price = temp / 100;
               
                piechartData.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double> { price },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });               
            }
            pie.Dock = DockStyle.Fill;
            pie.Series.Clear();
            pie.Series = piechartData;
            pie.LegendLocation = LegendLocation.Bottom;             
        }
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new SalesPresenter(new List<ISalesView> { cartesian });

            FillCartesianChart();

            FillAngular();

            FillSolid();

            FillPie();
        }

        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item selectedItem = ((Item)(ItemsList.SelectedItem));
            if(selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByItem(selectedItem.Name);
            double percent = Math.Round(
                presenter_.GetProfitPercentByItem(selectedItem), 2);

            angular.Value = percent;
            solid.Value = percent;
        }
    }
}
