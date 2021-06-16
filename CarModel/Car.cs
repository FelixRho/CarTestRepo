using System;

namespace CarModel
{
    public class Car
    {
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }

        public Car(string brand, string modelname, string color)
        {
            this.Brand = brand;
            this.ModelName = modelname;
            this.Color = color;
        }

        public int GetMaxSpeed()
        {
            if(this.Color == "red")
            {
                this.MaxSpeed = 250;
            }
            else
            {
                this.MaxSpeed = 150;
            }
        }

    }
}
