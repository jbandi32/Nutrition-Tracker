using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition_Tracker
{
    public class Food
    {
        private String name;
        private String size;
        private int calories;
        private double fat;

        public Food(String name, String size, int calories, double fat)
        {
            this.name = name;
            this.size = size;
            this.calories = calories;
            this.fat = fat;
        }

        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public String DisplayString
        {
            get
            {
                return name + " (" + size + ")";
            }
        }

        public String Size
        {
            get
            {
                return size;
            }
        }

        public int Calories
        {
            get
            {
                return calories;
            }
        }

        public double Fat
        {
            get
            {
                return fat;
            }
        }
    }
}
