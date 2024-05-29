using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Objects_As_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Red");

            // changeColor(car1, "Silver");

            Console.WriteLine(car1.color + " " + car1.model);

            Console.ReadKey();



            /* public static void changeColor( Car car, string color)
             {
                 car.color = color;
             }
            */


        }
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public string model;
        public string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
    
}
