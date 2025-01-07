using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel
{
    public class Car
    {
        public Car(string brand, string model, string color, int doorNumber)
        {
            Brand = brand;
            Model = model;
            Color = color;
            CarDoorNumber = doorNumber;
            Console.WriteLine($"Arabanın: \nMarka: {brand} \nModel: {model} \nRenk: {color} \nKapı Sayısı: {_carDoorNumber}");
        }

        private string? _brand;
        private string? _model;
        private string? _color;
        private int _carDoorNumber;
        public string? Brand { get { return _brand; } set { value = _brand; } }
        public string? Model { get { return _model; } set { value = _model; } }
        public string? Color { get { return _color; } set { value = _color; } }

       

       

        public int CarDoorNumber
        {
            get { return _carDoorNumber; }
            set
            {
                if (!(value == 2 || value == 4))
                {
                    Console.WriteLine($"{value} sayıda kapı koyulamaz.");
                    _carDoorNumber = -1;  
                }
                else
                {
                    _carDoorNumber = value;
                }
            }

        }
    }
}
