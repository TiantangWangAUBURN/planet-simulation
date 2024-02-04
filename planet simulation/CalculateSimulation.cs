using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planet_simulation
{
    internal class CalculateSimulation
    {
        
        double kg = 1000;
        double prePeopleEatKg = 0.1;

        public AllResult CalculateEat(string planet, int size, int time, int people, List<string> resources) 
        {

            var result = new AllResult();
            result.Count = resources.Count;
            result.Size = size;
            result.Time = time;
            result.People = people;
            if (planet == "moon")
            {
                result.Consumption = prePeopleEatKg * people * 7;
                result.ResourceDuration = prePeopleEatKg * people * time;
                 result.TotalEat = result.Consumption + result.ResourceDuration;

            }
            else if (planet == "mars")
            {
                result.Consumption = prePeopleEatKg * people * 900;
                result.ResourceDuration = prePeopleEatKg * people * time;
                result.TotalEat = result.Consumption + result.ResourceDuration;

            }

             result.TotalMaterial = kg * size * resources.Count;   

            
            return result;
            

        }
       
    }
}
