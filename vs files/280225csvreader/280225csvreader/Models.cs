using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _280225csvreader
{
    public class CsvRxW//Reader_x_Writer
    {
        public List<string[]> ReadCsv(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            return lines.Select(line => line.Split(',')).ToList();
        }

        public void WriteCsv(string filePath, List<string[]> data)
        {
            var lines = data.Select(arr => string.Join(",", arr)).ToArray();
            File.WriteAllLines(filePath, lines);
        }
    }

    public class CsvTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string DateOfSalary { get; set; }
        public int Amount { get; set; }
    }

    public class CvsManager
    {
        private List<CsvTable> cvsTable = new List<CsvTable>();
        private CsvRxW csvRxW = new CsvRxW();
        private const string filePath = "konbert-output-a4a19a26.csv";
        public void CreateCvs(CsvTable cvsline)
        {
            cvsTable.Add(cvsline);
            SaveCvs();
        }

        public void UpdateCvs(int id, CsvTable updatedCsvLine)
        {
            var a = cvsTable.FirstOrDefault(r => r.Id == id);
            if (a != null)
            {
                a.Name = updatedCsvLine.Name;
                a.Price = updatedCsvLine.Price;
                a.DateOfSalary = updatedCsvLine.DateOfSalary;
                a.Amount = updatedCsvLine.Amount;
                SaveCvs();
            }
        }

        public void DeleteCvs(int id)
        {
            var a = cvsTable.FirstOrDefault(r => r.Id == id);
            if (a != null)
            {
                cvsTable.Remove(a);
                SaveCvs();
            }
        }

        public List<CsvTable> GetCvs()
        {
            return cvsTable;
        }

        public void LoadCvs()
        {
            var data = csvRxW.ReadCsv(filePath);
            cvsTable = data.Select(arr => new CsvTable
            {
                Id = int.Parse(arr[0]),
                Name = arr[1],
                Price = int.Parse(arr[2]),
                DateOfSalary = arr[3],
                Amount = int.Parse(arr[4]),
            }).ToList();//?????????????????????????????????????????????????????????????????????????????
        }

        private void SaveCvs()
        {
            var data = cvsTable.Select(r => new string[] { r.Id.ToString(), r.Name, r.Price.ToString(), r.DateOfSalary, r.Amount.ToString() }).ToList();
            csvRxW.WriteCsv(filePath, data);
        }

        //filter
        public List<CsvTable> FilterCvsDates(string date)
        {
            return cvsTable.Where(r => r.DateOfSalary.Equals(date, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        public List<CsvTable> FilterCvsprice(int minValue, int maxValue)
        {
            return cvsTable.Where(r => double.TryParse(r.Price.ToString(), out double value) && value >= minValue && value <= maxValue).ToList();
        }


        //agrigations
        public int CountCvs()
        {
            return cvsTable.Count;
        }

        public double AverageValue()
        {
            return cvsTable.Average(r => double.TryParse(r.Price.ToString(), out double result) ? result : 0);
        }
        
    }
}
