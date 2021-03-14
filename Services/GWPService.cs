using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galytix.WebApi.Data;
using Galytix.WebApi.Helpers;
using Galytix.WebApi.Models;
using Galytix.WebApi.Repositories;

namespace Galytix.WebApi.Service
{
    public class GWPService
    {
        private readonly IGWPRepository gWPRepository;
        private List<Func<GWPData, double?>> funcList = new List<Func<GWPData, double?>>
                {
                    d => d.Y2008,
                    d => d.Y2009,
                    d => d.Y2010,
                    d => d.Y2011,
                    d => d.Y2012,
                    d => d.Y2013,
                    d => d.Y2014,
                    d => d.Y2015,
                };

        public GWPService(IGWPRepository gWPRepository)
        {
            this.gWPRepository = gWPRepository;
        }


        public async Task<Dictionary<string, double>> GetData(Input input)
        {
            var countryData = await gWPRepository.GetGWPData(input);
            var dictToReturn = new Dictionary<string, double>();
            foreach (var lob in input.linesOfBusiness)
            {
                var lobData = countryData.FirstOrDefault(x => x.LineOfBusiness == lob);
                var avg = Calculator.CalculateAverage(lobData, funcList);
                dictToReturn.Add(lob, avg);
            }
            return dictToReturn;
        }
        
    }
}