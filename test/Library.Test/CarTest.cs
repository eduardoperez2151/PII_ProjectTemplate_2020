using NUnit.Framework;

namespace Template
{
    public class CarTest
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            car = new Car("BMW");
        }

        [Test]
        public void Test1()
        {

            car.TurnOn();
            Assert.AreEqual(car.IsOn, true);
        }
    }
}