using System;
using System.Collections.Generic;

namespace WhoIsIt.Models
{
    class Category
    {
        CategoryName name;
        Rider[] riders;

        public Category(CategoryName name, Rider[] riders)
        {
            this.name = name;
            this.riders = riders;
        }

        public Rider FindRider(int number)
        {
            foreach (Rider rider in riders)
                if (rider.Find(number))
                    return rider;
            return new Rider();
        }
    }
}