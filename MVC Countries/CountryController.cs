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
            new Country("China",Country.Continent.Asia,new List<string>{"Red","Gold"}),
            new Country("Mexico",Country.Continent.North_America,new List<string>{"Green","Red","White"}),
            new Country("Canada",Country.Continent.North_America,new List<string>{"Red","White"}),
            new Country("Italy",Country.Continent.Europe,new List<string>{"Green", "White", "Red"}),
            new Country("Germany",Country.Continent.Europe,new List<string>{"Red","Black","Yellow"}),
            new Country("France",Country.Continent.Europe,new List<string>{"Red","White","Blue"}),
            new Country("Djibouti",Country.Continent.Africa,new List<string>{"Green","Blue","White","Red"}),
            new Country("South Africa",Country.Continent.Africa,new List<string>{"Red","White","Green","Blue","Black","Gold"}),
            new Country("The United States of America",Country.Continent.North_America,new List <string> {"Red", "White", "Blue"})
        };

        public void CountryAction(Country c)
        {
            


        }

        public void WelcomeAction()
        {



        }

        public void CountryListAction()
        {



        }




    }
}
