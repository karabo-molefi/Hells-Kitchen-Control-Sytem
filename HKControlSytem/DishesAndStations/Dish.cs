using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKControlSytem.DishesAndStations
{
    internal class Dish
    {
        public string DishName;
        public string Category;
        public int PreparationTime;
        public string Difficulty;
        public string assignedContestant;
        public string KitchenStation;

        // Constructor
        Dish(string name, string category, int time, string difficulty, string contestant, string station)
        {
            this.DishName = name;
            this.Category = category;
            this.PreparationTime = time;
            this.Difficulty = difficulty;
            this.assignedContestant = contestant;
            this.KitchenStation = station;
        }


    }
}
