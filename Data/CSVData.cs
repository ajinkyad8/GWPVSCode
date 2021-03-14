using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Galytix.WebApi.Models;
namespace Galytix.WebApi.Data
{
    public class CSVData
    {
        public readonly Dictionary<string, List<GWPData>> GWPDataDictionary;
        public CSVData()
        {            
            using (var reader = new StreamReader("Data\\gwpByCountry.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<GWPData>();
                GWPDataDictionary = records.GroupBy(x => x.Country).ToDictionary(x => x.Key, y => y.ToList());
            }
        }
    }
}