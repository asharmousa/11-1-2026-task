using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _11_1_2026
{
    public class Car
    {
        //constructor
        //public Car { get; set; }
        private string brand;
        private string model;
        private string year;
        
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string owner { get; set; } //auto=implemented property 
        //No return value method (void)
        public void Start ()
        {
            Console.WriteLine("that car in starting");
        }

        public void  Drive()
        {
            Console.WriteLine("that the car is driving");
        }

        public void Stop()
        {
            Console.WriteLine(" that the car has stoppe");
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        // Create objects 
        Car car1 = new Car();
        Car car2 = new Car();

            //Assign values 
            car1.Brand = "Mercedes";
            car1.Year = "2026";
            car1.Model = "Benz Maybach S 680";

            car2.Brand = "Mercede";
            car2.Year = "2026";
            car2.Model = "Benz Maybach SL 680 Monogram Series";

            //Call methods
            car1.Start();
            car1.Drive();
            car1.Stop();

            
            car2.Start();
            car2.Drive();
            car2.Stop();

            //print the values
            Console.WriteLine($"Car 1 : Brand name {car1.Brand} Model {car1.Model} & year {car1.Year}");

            Console.WriteLine($"Car 2 : Brand name {car2.Brand} Model {car2.Model} & year {car2.Year}");

        }
    }
}
