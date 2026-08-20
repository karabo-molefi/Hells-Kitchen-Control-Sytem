using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKControlSytem.Contestant
{
    internal class Contestant
    {
        protected int ContestantNumber;

        public string Name;

        public int Age;

        public int  YearsofCookingExperience;

        public string Team;

        // Constructor

        Contestant (int contestantNumber, string name, int age, int yearsExperience, string team)
        {
            this.ContestantNumber = contestantNumber;
            this.Name = name;
            this.Age = age;
            this.YearsofCookingExperience = yearsExperience;
            this.Team = team;
        }


    }
}
