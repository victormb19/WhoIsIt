using System;

namespace WhoIsIt.Models
{
    struct Rider
    {
        string name;
        int number;
        string country;
        string team;
        string bike;
        string placeOfBirth;

        public Rider(string name, int number, string country, string team, string bike, string placeOfBirth)
        {
            this.name = name;
            this.number = number;
            this.country = country;
            this.team = team;
            this.bike = bike;
            this.placeOfBirth = placeOfBirth;
        }

        public bool Find(int number)
        {
            return this.number == number;
        }

        public string GetName()
        {
            return name;
        }

        public string GetNumber()
        {
            return number.ToString();
        }

        public string GetCountry()
        {
            return country;
        }

        public string GetTeam()
        {
            return team;
        }

        public string GetBike()
        {
            return bike;
        }

        public string GetPlaceOfBirth()
        {
            return placeOfBirth;
        }
    }
}
