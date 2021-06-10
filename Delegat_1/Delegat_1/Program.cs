
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{

    public delegate void MyDelegat(Car car);

    public class Car
    {
        private string marka;

        public Car(string marka)
        {
            this.marka = marka;
        }

        public override string ToString()
        {
            return marka;
        }
    }

    class Garage
    {
        private List<Car> cars = new List<Car>();

        public Garage(params Car[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                cars.Add(list[i]);
            }
        }

        public Car this[int index]
        {
            get { return cars[index]; }
        }

        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < cars.Count; i++)
            {
                str += i + " " + cars[i] + "\n";
            }
            return str;
        }
    }

    class Washer
    {
        static public void Wash(Car car)
        {
            Console.WriteLine(car + " помита");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW");
            Car car1 = new Car("Hundai");
            Car car2 = new Car("Audi");
            Garage gr = new Garage(car, car1, car2);
            Console.WriteLine(gr);
            MyDelegat delegat = Washer.Wash;
            delegat(gr[0]);
        }
    }
}
