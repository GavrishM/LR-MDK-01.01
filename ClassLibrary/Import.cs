using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Import
    {
        public Dictionary<string, List<Medicine>> ImportFromTxt(string path) 
        {
            Dictionary<string, List<Medicine>> result = new Dictionary<string, List<Medicine>>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    line = line.Trim();

                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("Категория"))
                        continue;

                    string[] parts = line.Split(';');

                    if (parts.Length >= 8)
                    {
                        string category = parts[0].Trim();

                        Medicine medicine = new Medicine(
                            name: parts[1].Trim(),
                            image: parts[2].Trim(),
                            cost: double.Parse(parts[3].Trim(), CultureInfo.InvariantCulture),
                            manufacturer: parts[4].Trim(),
                            supplier: parts[5].Trim(),
                            expirationDate: parts[6].Trim(),
                            description: parts[7].Trim()
                        );

                        if (!result.ContainsKey(category))
                            result[category] = new List<Medicine>();

                        result[category].Add(medicine);
                    }
                }
            }
            return result;
        }
    }
}
