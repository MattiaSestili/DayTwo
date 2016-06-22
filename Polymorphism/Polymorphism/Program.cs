using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Vehicle
        {
            public string name;
            public string type;
            public string model;
            public bool sold;
            public int price;
            public int wheels;

            public void AddVehicle(string type, string name, string model, int price)
            {
                this.type = type;
                this.name = name;
                this.model = model;
                this.price = price;
            }

            public void Sold(bool sold, int price)
            {
                this.sold = sold;
                this.price = price;
            }

            public virtual int NumberWheels()
            {
                return wheels;
            }
        }

        class Car : Vehicle
        {
            public static int totalNumberOfCar;

            public void addCar(string name, string model, int price)
            {
                AddVehicle(type = "Car", name, model, price);
                totalNumberOfCar++;

            }

            public void SoldCar(bool isSold, int price)
            {
                Sold(isSold, price);
                totalNumberOfCar--;
            }

            public override int NumberWheels()
            {
                return 4;
            }
        }

        class Motorcycle : Vehicle
        {
            public static int totalNumberOfMotorcycle;

            public void addMotorcycle(string name, string model, int price)
            {
                AddVehicle(type = "Motorcycle", name, model, price);
                totalNumberOfMotorcycle++;
            }
            public void SoldMotorcycle(bool isSold, int price)
            {
                Sold(isSold, price);
                totalNumberOfMotorcycle--;
            }

            public override int NumberWheels()
            {
                return 2;
            }
        }


    class Program
    {
        static void Main(string[] args)
        {
            string listVehicle;

            List<Vehicle> allVehicleList = new List<Vehicle>();

            Car car1 = new Car();
            car1.addCar("Ferrari", "458 Italia", 236340);
            car1.NumberWheels();
            allVehicleList.Add(car1);

            Car car2 = new Car();
            car2.addCar("Mercedes", "A-Class", 28650);
            car1.NumberWheels();
            allVehicleList.Add(car2);

            Car car3 = new Car();
            car3.addCar("Fiat", "500L", 10000);
            car1.NumberWheels();
            allVehicleList.Add(car3);

            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.addMotorcycle("Kawasaki", "Ninja 600", 8000);
            motorcycle1.NumberWheels();
            allVehicleList.Add(motorcycle1);

            Motorcycle motorcycle2 = new Motorcycle();
            motorcycle2.addMotorcycle("Ducati", "Desmosedici", 15000);
            motorcycle2.NumberWheels();
            allVehicleList.Add(motorcycle2);

            Console.WriteLine("Car List: ");
            for (int i = 0; i < allVehicleList.Count; i++)
            {
                if(allVehicleList[i].type == "Car")
                {
                    listVehicle = allVehicleList[i].name + " " + allVehicleList[i].model + ": " + allVehicleList[i].price + "£";
                    Console.WriteLine("The model available in the showroom is: {0} ", listVehicle);
                }
            }

            Console.WriteLine("\nMotorcycle List: ");
            for (int i = 0; i < allVehicleList.Count; i++)
            {
                if (allVehicleList[i].type == "Motorcycle")
                {
                    listVehicle = allVehicleList[i].name + " " + allVehicleList[i].model + ": " + allVehicleList[i].price + "£";
                    Console.WriteLine("The model available in the showroom is: {0} ", listVehicle);
                }                
            }

            motorcycle1.Sold(true, 8000);
            car1.Sold(true, 23000);
            

            Console.WriteLine("The number of cars in stock is: {0} ", Car.totalNumberOfCar);
            Console.WriteLine("The number of motorcycle in stock is: {0} ", Motorcycle.totalNumberOfMotorcycle);

            Console.WriteLine("Every car in the showroom has: {0} wheels", car1.NumberWheels());
            Console.WriteLine("Every motorcycle in the showroom has: {0} wheels", motorcycle1.NumberWheels());
        }
    }
}


