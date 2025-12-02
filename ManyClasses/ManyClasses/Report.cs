using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    public class Report
    {
        //private Dictionary<Product, double> Products_;
        //private double Sum_;
        //
        //public void SetStorage(Storage storage)
        //{
        //    Products_ = storage.GetProducts();
        //    Sum_ = storage.CalcMoney();
        //}
        //public void PrintReport()
        //{
        //    foreach (Product product in Products_.Keys)
        //    {
        //        Console.WriteLine(product.GetPrice() + " " + product.GetName() + " " + Products_[product]);
        //    }
        //    Console.WriteLine(Sum_);
        //}
        private List<Row> Rows_ = new List<Row>();
        private Storage Storage_ = new Storage();

        public void AddRow (Row row)
        {
            Rows_.Add(row);
        }
        public void AddRow (List<Row> rows)
        {
            Rows_.AddRange(rows);
        }
        public string ReportToString()
        {
            string report = "";
            double sum = 0;
            foreach (Row row in Rows_)
            {
                report += (row.Price + ";" + row.Product + ";" + row.Quantity + "\n");
                sum += row.Price * row.Quantity;
            }
            report += ("Итоговая сумма = " + sum);
            return(report);
        }
        
    }
}
