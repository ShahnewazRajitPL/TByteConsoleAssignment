using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Color
    {
        Red,
        Green,
        Blue,
        Black

    }
    internal class Car
    {
        private readonly Color _color= default;
        private string _name ="audi";
        private string _brand ="au-1";
        private DateTime _year;
        private int? _speed=null;

        public string Name
        {
            get
            {
                return _name;

            }

            set
            {
                if (_name != value)
                {
                    Console.WriteLine("something");
                }
                _name = value;

            }
        }

        public static int price;

        //Default Constructor
        public Car()
        {
            Console.WriteLine($"{_name} has created.");

        }

        //Full construstor

        public Car(Color color, string name, string brand, DateTime year, int speed=1)
        {
            _color = color;
            _name = name;
            _brand = brand;
            _year = year;
            _speed = speed;
        }

        public Car(Color color, string name)
        {
            _color = color;
            _name = name;

        }

        public void SetCarName(string name)
        {
            _name = name;
        }

        public string GetCarName()
        {
            return _name;

        }

        public void Start()
        {
            Console.WriteLine($"{Name} has started.");

        }
        public void Speed()
        {
            Console.WriteLine($"{_name} speed is {_speed} km/h");
        }

        public void CarDetails()
        {
            Console.WriteLine($"{_name} speed is {_speed} km/h,which color is  {_color} . This car has manufactured {_year} years. Car");
        }

    }
}
