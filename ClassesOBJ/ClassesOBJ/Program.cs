using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.totalNumberOfCar = 0;
          
            List<Car> carsList = new List<Car>();

            Car car1 = new Car();
            car1.addCar("Ferrari", "458 Italia", 236340);
            carsList.Add(car1);
            Car.totalNumberOfCar++;

            Car car2 = new Car();
            car2.addCar("Mercedes", "A-Class", 28650);
            carsList.Add(car2);
            Car.totalNumberOfCar++;

            Car car3 = new Car();
            car3.addCar("Fiat", "500L", 10000);
            carsList.Add(car3);
            Car.totalNumberOfCar++;
         }
    }

    class Car
    {
        public string name;
        public string model;
        public int totalRent;
        public int price;
        public bool sold;

        public static int totalNumberOfCar;

        public void addCar(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
        }

        public static int carShowRoom(List<Car> carList)
        {
            int total = 0;

            foreach(Car car in carList)
            {
                total += car.price;
            }

            return total;
        }

        public static int valueOfStock(List<Car> carList)
        {
            int total = 0;
            foreach (Car car in carList)
            {
                if (car.sold == false)
                {
                    total = car.price / totalNumberOfCar;
                }
            }

            return total;
        }
    }
}
