using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arbol_Genealogico.Modelo.Servicios
{
    public class DateTime_JsonConverter
    {
        public DateTime? ConvertFromJsonToDateTime(string arg)
        {
            DateTime dateTime;

            string[] validformats = new[] { "MM/dd/yyyy" };
            CultureInfo provider = new CultureInfo("en-US");

            try
            {
                dateTime = DateTime.ParseExact(arg, validformats, provider);
                return dateTime;
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse the specified date");
                return null;
            }            
        }

        public string ConvertFromDateTimeToJson(DateTime date)
        {
            string dateTime;

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                DateFormatString = "MM/dd/yyyy",
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };

            dateTime = JsonConvert.SerializeObject(date, settings);

            return dateTime;
        }
    }
}
