using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {

        public SUV()
        {
        }

        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "4-Runner";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "Let's go places!";
        public bool HasChangedGears { get; set; }
        

        public void Drive()
        {
            {
                Console.WriteLine($"The {GetType().Name} is now driving forward!");
            }
            
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now reversing!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears!");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears!");
            }

        }

        public void ChangeGears(bool hasChanged)
        {
            HasChangedGears = hasChanged; 
        }




    }
}
