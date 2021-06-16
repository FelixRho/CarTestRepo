using CarModel;
using System;
using System.Collections.Generic;
using Xunit;

namespace CarTest
{
    public class TestCar
    {
        static string brand = "Audi";
        static string model = "A Drölf";
        static string color = "schwarz";

        [Fact]
        public void Constructor_Passing()
        {
            Car car = new Car(brand, model, color);

            Assert.Equal(brand, car.Brand);
            Assert.Equal(model, car.ModelName);
            Assert.Equal(color, car.Color);
        }


        public static IEnumerable<object[]> Car_Failing()
        {
            yield return new object[] { "Car", null, false};
            yield return new object[] {null, "black", true };
            yield return new object[] { "Car", string.Empty, false };
            yield return new object[] { string.Empty, "black", true };
            yield return new object[] { "Car", " ", false };
            yield return new object[] { " ", "black", true };
        }



        [Theory]
        [MemberData(nameof(Car_Failing))]
        public void Constructor_Failing(string Brand, string Color, bool IsBrand)
        {
            Car car;

            Exception ex = Assert.Throws<ArgumentNullException>(() => car = new Car(Brand, model, Color));

            if(IsBrand)
            {
                Assert.Equal($"Value cannot be null. (Parameter '{nameof(car.Brand)}')", ex.Message);
            }
            else
            {
                Assert.Equal($"Value cannot be null. (Parameter '{nameof(car.Color)}')", ex.Message);
            }
        }

    }
}
