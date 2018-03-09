using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class PublishingHouse
    {
        string name;
        string country;
        string city;
        int year;
        bool isPublic;

        public PublishingHouse()
        {
        }

        public PublishingHouse(string name, string country, string city, int year, bool isPublic)
        {
            this.name = name;
            this.country = country;
            this.city = city;
            this.year = year;
            this.isPublic = isPublic;
        }
        #region Properties
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public int Year { get => year; set => year = value; }
        public bool IsPublic { get => isPublic; set => isPublic = value; }
        #endregion

        public override string ToString()
        {
            if(IsPublic)
                return $"{Name}, {country}, г.{city}, {year}г. Публичное";
            else 
                return $"\"{Name}\", {country}, г.{city}, {year}г. Государственное";
        }

    }
}
