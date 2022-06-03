using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Tundra";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "Let's go places!";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if(HasFourWheelDrive == true)
            {
                Console.WriteLine($"The 4-wheel drive {GetType().Name} is now driving forward!");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving forward!");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The 4-Wheel drive {GetType().Name} is now reversing!");
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
