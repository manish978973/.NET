using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projectpro
{
    public class Vacancy

    {
        string name;
        string place;
        string country;

        public Vacancy() { }

        public Vacancy(string Name,string Place)
        {
            name = Name;
            place = Place;
          
        }
        public Vacancy(string Name, string Place,string Country)
        {
            name = Name;
            place = Place;
            country = Country;
        }


        public string Name { get { return name; } set { name = value; } }
        public string Place { get { return place; } set { place = value; } }
        public string Country { get { return country; } set { country= value; } }




    }
}