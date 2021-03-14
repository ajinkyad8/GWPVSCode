using System.ComponentModel.DataAnnotations.Schema;
using CsvHelper.Configuration.Attributes;

namespace Galytix.WebApi.Models
{
    public class GWPData
    {
        [Name("country")]
        public string Country { get; set; }
        [Name("variableId")]
        public string VariableId { get; set; }
        [Name("variableName")]
        public string VariableName { get; set; }
        [Name("lineOfBusiness")]
        public string LineOfBusiness { get; set; }
        public double? Y2000 { get; set; }
        public double? Y2001 { get; set; }
        public double? Y2002 { get; set; }
        public double? Y2003 { get; set; }
        public double? Y2004 { get; set; }
        public double? Y2005 { get; set; }
        public double? Y2006 { get; set; }
        public double? Y2007 { get; set; }
        public double? Y2008 { get; set; }
        public double? Y2009 { get; set; }
        public double? Y2010 { get; set; }
        public double? Y2011 { get; set; }
        public double? Y2012 { get; set; }
        public double? Y2013 { get; set; }
        public double? Y2014 { get; set; }
        public double? Y2015 { get; set; }
    }
}
