using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTest
{
    [TestClass]
    public class ImportTest
    {
        [TestMethod]
        public void ImportFromTxtTest()
        {
            string path = "../../../LR3/TestImp.txt";
            Import import = new Import();

            Dictionary<string, List<Medicine>> actual = import.ImportFromTxt(path);
            string actualCategory = "";
            foreach (string key in actual.Keys) actualCategory = key;
            List<Medicine> actualList = actual[actualCategory];
            Medicine actualMedicine = actualList[0];

            Dictionary<string, List<Medicine>> expected = new Dictionary<string, List<Medicine>>();
            string expectedCategory = "Лекарства от кашля";
            List<Medicine> expectedList = new List<Medicine>();
            Medicine expectedMedicine = new Medicine("Амброксол", "../../../Import/Imp", 47, "ООО Амброксол", "ООО Амброксол", "15 недель", "Лекарство от кашля (таблетки)");
            expectedList.Add(expectedMedicine);
            expected.Add(expectedCategory, expectedList);


            if (expected.Count == actual.Count)
            {
                CollectionAssert.AreEqual(expected.Keys, actual.Keys);
                Assert.AreEqual(expectedCategory, actualCategory);
                {
                    Assert.AreEqual(expectedMedicine.Name, actualMedicine.Name);
                    Assert.AreEqual(expectedMedicine.Image, actualMedicine.Image);
                    Assert.AreEqual(expectedMedicine.Cost, actualMedicine.Cost);
                    Assert.AreEqual(expectedMedicine.Manufacturer, actualMedicine.Manufacturer);
                    Assert.AreEqual(expectedMedicine.Supplier, actualMedicine.Supplier);
                    Assert.AreEqual(expectedMedicine.ExpirationDate, actualMedicine.ExpirationDate);
                    Assert.AreEqual(expectedMedicine.Description, actualMedicine.Description);
                }
            }
        }
    }
}
