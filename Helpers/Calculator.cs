using System;
using System.Collections.Generic;
using System.Linq;
using Galytix.WebApi.Models;

namespace Galytix.WebApi.Helpers
{
    public class Calculator
    {
        public static double CalculateAverage(GWPData data, List<Func<GWPData, double?>> parameters)
        {
            if (data == null)
            {
                return 0;
            }
            double total = 0;
            double count = 0;
            foreach (var parameter in parameters)
            {
               if (parameter(data).HasValue)
               {
                   total += parameter(data).Value;
                   count++;
               }
            }
            return count > 0 ? Math.Round(total/count , 1) : 0;
        }
    }
}