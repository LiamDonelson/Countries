using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryController
    {
        public List<Country> CountryDB { get; set; } = new List<Country>()
        {
            new Country("China",Country.Continent.Asia,"Red Gold"),
            new Country("Mexico",Country.Continent.North_America,"Green Red White"),
            new Country("Canada",Country.Continent.North_America,"Red White"),
            new Country("Italy",Country.Continent.Europe,"Green White Red"),
            new Country("Germany",Country.Continent.Europe,"Red Black Yellow"),
            new Country("France",Country.Continent.Europe,"Red White Blue"),
            new Country("Djibouti",Country.Continent.Africa,"Green Blue White Red"),
            new Country("South Africa",Country.Continent.Africa,"Red White Green Blue Black Gold"),
            new Country("The United States of America",Country.Continent.North_America,"Red White Blue")
        };

        public void CountryAction(Country c)
        {
            CountryView a = new CountryView(c);

            a.Display();

        }

        public void WelcomeAction()
        {
            CountryListView cat = new CountryListView(CountryDB);
            Console.WriteLine("Welcome to this beech!!!! sucks to suck i guess select a numb");
            cat.Display();
            int input = int.Parse(Console.ReadLine());

            CountryAction(CountryDB[input]);
        }

    }
}
