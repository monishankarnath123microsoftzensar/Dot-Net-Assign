using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public enum VehType
    {
        Car,
        Truck,
        Bus
    }
    public enum FuelType
    {
        Diesel,
        Petrol,
        CNG
    }

    public class Vehicle
    {
        string name;
        string color;
        int NoOfWheels;
        int Vehtype;
        int Fueltype;
        string make;


        public void Start()
        {
            if (Vehtype == (int)VehType.Bus)
            {
                Console.WriteLine("{0} has started.....", VehType.Bus);
            }

            else if (Vehtype == (int)VehType.Car)
            {
                Console.WriteLine("{0} has started.....", VehType.Car);
            }

            else if (Vehtype == (int)VehType.Truck)
            {
                Console.WriteLine("{0} has started.....", VehType.Truck);
            }


        }

        public void Stop()
        {
            if (Vehtype == (int)VehType.Bus)
            {
                Console.WriteLine("{0} has stoped.....", VehType.Bus);
            }

            else if (Vehtype == (int)VehType.Car)
            {
                Console.WriteLine("{0} has stoped.....", VehType.Car);
            }

            else if (Vehtype == (int)VehType.Truck)
            {
                Console.WriteLine("{0} has stoped.....", VehType.Truck);
            }


        }

        public Vehicle(string _name, string _color)
        {
            name = _name;
            color = _color;
        }

        public Vehicle(params Object[] arr)
        {

            name = (string)arr[0];
            color = (string)arr[1];
            NoOfWheels = (int)arr[3];
            Vehtype = (int)arr[2];
            Fueltype = (int)arr[4];

        }

        public void Display()
        {
            string vech;
            string fuel;
            if (Vehtype == 0)
            {
                vech = "Car";
                fuel = "Petrol";
            }

            else if (Vehtype == 1)
            {
                vech = "Truck";
                fuel = "Diesel";
            }
            else
            {
                vech = "Bus";
                fuel = "Diesel";
            }

            Console.WriteLine("Vehicle Type : {0}", vech);
            Console.WriteLine("Vehicle Name : {0}", name);
            Console.WriteLine("Vehicle Color : {0}", color);
            Console.WriteLine("No. Of Wheels : {0}", NoOfWheels);
            Console.WriteLine("Fuel Type : {0}", fuel);
        }

    }

}


