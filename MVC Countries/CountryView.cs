using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MVC_Countries.Country;

namespace MVC_Countries
{
    public class CountryView  
    {
        public Country DisplayCountry { get; set; }


        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        public void Display()
        {

            Console.WriteLine($"Name: {DisplayCountry.Name} Continent: {DisplayCountry.Contient} Colors : {DisplayCountry.Colors}");
        }

    }
}
