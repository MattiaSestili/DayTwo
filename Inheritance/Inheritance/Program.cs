using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
        class Vehicle
        {
            public string name;
            public string type;
            public string model;
            public bool sold;
            public int price;

            public void AddVehicle(string type, string name, string model, int price)
            {
                this.type = "";
                this.name = name;
                this.model = model;
                this.price = price;
            }

            public void Sold (bool sold, int price)
            {
                this.sold = sold;
                this.price = price;
            }
        }

        class Car : Vehicle
        {
            int totalNumberOfCar = 0;
            bool Sold;

            public void addCar (string name, string model, int price)
            {
                AddVehicle(type = "Car", name, model, price);
                totalNumberOfCar++;

            }

            public void SoldCar (bool isSold, int price)
            {
                Sold(isSold, price);
                totalNumberOfCar--;
            }
        }

        class Motorcycle : Vehicle
        {
           public static int totalNumberOfMotorcycle = 0;

            public void addMotorcycle (string name, string model, int price)
            {
                AddVehicle(type = "Motorcycle", name, model, price);
                totalNumberOfMotorcycle++;
            }
            public void SoldMotorcycle(bool isSold, int price)
            {
                Sold(isSold, price);
                totalNumberOfMotorcycle--;
            }
        }


    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> allVehicleList = new List<Vehicle>();

            Car car1 = new Car();
            car1.addCar("Ferrari", "458 Italia", 236340);
            allVehicleList.Add(car1);

            Car car2 = new Car();
            car2.addCar("Mercedes", "A-Class", 28650);
            allVehicleList.Add(car2);

            Car car3 = new Car();
            car3.addCar("Fiat", "500L", 10000);
            allVehicleList.Add(car3);

            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.addMotorcycle("kawasaki", "Ninja 600", 8000);
            allVehicleList.Add(motorcycle1);

            Motorcycle motorcycle2 = new Motorcycle();
            motorcycle2.addMotorcycle("Ducati", "Desmosedici", 15000);
            allVehicleList.Add(motorcycle2);

            string listVehicle = "";

            for (int i = 0; i < allVehicleList.Count; i++)
            {
                listVehicle += allVehicleList[i].name + allVehicleList[i].model + allVehicleList[i].price;

            }
            Console.WriteLine(listVehicle);
            Console.WriteLine(Motorcycle.totalNumberOfMotorcycle);

            motorcycle1.Sold(true, 8000);
            car1.Sold(true, 23000);
        }
    }
}