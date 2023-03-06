using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorAndConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine($"Name:{car1.Name} Speed:{car1.Speed} Color:{car1.Color}");
            Console.ReadKey();
            
            
        }
    }
    public class Car
    {
        public int Speed;
        public string Name;
        public string Color;
        
        public Car()
        {
            this.Speed = 150;
            this.Name = "BMW";
            this.Color = "Black";
        }
        
        public Car (int Speed , string Name)
        {
            this.Speed = 150;
            this.Name = "Praide";
            this.Color = "Pink";
        }
        public Car(int Speed,string Name,string color)
        {
            this.Speed = 150;
            this.Name = "MVM";
            this.Color = "Red";
        }
        
    }
}
