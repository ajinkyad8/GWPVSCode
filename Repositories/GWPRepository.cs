using System.Collections.Generic;
using System.Threading.Tasks;
using Galytix.WebApi.Data;
using Galytix.WebApi.Models;

namespace Galytix.WebApi.Repositories
{
    public class GWPRepository : IGWPRepository
    {
        private readonly CSVData cSVData;

        public GWPRepository(CSVData cSVData)
        {
            this.cSVData = cSVData;
        }
        public async Task<List<GWPData>> GetGWPData(Input input)
        {
            return await Task.Run (() => GetCountryDataList(input));
        }
        public List<GWPData> GetCountryDataList(Input input)
        {
            return cSVData.GWPDataDictionary.ContainsKey(input.country) ? cSVData.GWPDataDictionary[input.country] : new List<GWPData>();
        }
    }
}