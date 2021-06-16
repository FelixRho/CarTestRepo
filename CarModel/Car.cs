using System;

namespace CarModel
{
    public class Car
    {
        private string brand;
        private string color;

        public string ModelName { get; set; }
        public string Brand
        {
            get => this.brand; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Brand));

                this.brand = value;
            }

        }
        public int MaxSpeed { get; set; }
        public string Color
        {
            get => this.color; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Color));

                this.color = value;
            }
        }

        public Car(string brand, string modelname, string color)
        {
            this.Brand = brand;
            this.ModelName = modelname;
            this.Color = color;
            this.MaxSpeed = 0;
        }





        public void GetMaxSpeed()
        {
            if (this.Color == "red")
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
