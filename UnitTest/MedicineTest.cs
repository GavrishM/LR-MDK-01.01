using System;
using System.IO;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTest
{
    [TestClass]
    public class MedicineTest
    {
        [TestMethod]
        public void MedicineConstructorTest()
        {
            //p1
            {
                string name = "Амброксол";
                string image = "";
                double cost = 47;
                string manufacturer = "ООО Амброксол";
                string supplier = "ООО Амброксол";
                string expirationDate = "15 недель";
                string description = "Лекарство от кашля (таблетки)";

                Medicine medicine = new Medicine(name, image, cost, manufacturer, supplier, expirationDate, description);

                Assert.AreEqual(name, medicine.Name);
                Assert.AreEqual(image, medicine.Image);
                Assert.AreEqual(cost, medicine.Cost);
                Assert.AreEqual(manufacturer, medicine.Manufacturer);
                Assert.AreEqual(supplier, medicine.Supplier);
                Assert.AreEqual(expirationDate, medicine.ExpirationDate);
                Assert.AreEqual(description, medicine.Description);
            }//p1
            //p2
            {
                string name = "Коделак";
                string image = "";
                double cost = 32;
                string manufacturer = "ООО Коделак";
                string supplier = "ООО Коделак";
                string expirationDate = "4 недели";
                string description = "Лекарство от кашля (сироп)";

                Medicine medicine = new Medicine(name, image, cost, manufacturer, supplier, expirationDate, description);

                Assert.AreEqual(name, medicine.Name);
                Assert.AreEqual(image, medicine.Image);
                Assert.AreEqual(cost, medicine.Cost);
                Assert.AreEqual(manufacturer, medicine.Manufacturer);
                Assert.AreEqual(supplier, medicine.Supplier);
                Assert.AreEqual(expirationDate, medicine.ExpirationDate);
                Assert.AreEqual(description, medicine.Description);
            }//p2
            //p3
            {
                string name = "Терафлю";
                string image = "";
                double cost = 68;
                string manufacturer = "ООО Терафлю";
                string supplier = "ООО Терафлю";
                string expirationDate = "2 недели";
                string description = "Жаропонижающее (пакетики)";

                Medicine medicine = new Medicine(name, image, cost, manufacturer, supplier, expirationDate, description);

                Assert.AreEqual(name, medicine.Name);
                Assert.AreEqual(image, medicine.Image);
                Assert.AreEqual(cost, medicine.Cost);
                Assert.AreEqual(manufacturer, medicine.Manufacturer);
                Assert.AreEqual(supplier, medicine.Supplier);
                Assert.AreEqual(expirationDate, medicine.ExpirationDate);
                Assert.AreEqual(description, medicine.Description);
            }//p3
            //p4
            {                
                string name = "Nurofen";
                string image = "";
                double cost = 89;
                string manufacturer = "ООО Nurofen";
                string supplier = "ООО Nurofen";
                string expirationDate = "15 недель";
                string description = "Жаропонижающее (таблетки)";

                Medicine medicine = new Medicine(name, image, cost, manufacturer, supplier, expirationDate, description);

                Assert.AreEqual(name, medicine.Name);
                Assert.AreEqual(image, medicine.Image);
                Assert.AreEqual(cost, medicine.Cost);
                Assert.AreEqual(manufacturer, medicine.Manufacturer);
                Assert.AreEqual(supplier, medicine.Supplier);
                Assert.AreEqual(expirationDate, medicine.ExpirationDate);
                Assert.AreEqual(description, medicine.Description);
            }//p4
        }
    }
}
