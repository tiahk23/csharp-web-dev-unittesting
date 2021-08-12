using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    

    [TestClass]
    public class CarTests
    {
        

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);

        }

        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Pirus", 10, 50);
        }

        [TestMethod]
        public void TestInitialGasTank()
        {
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }

        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            test_car.Drive(550);

            Assert.AreEqual(0, test_car.GasTankLevel, .001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
    }

            
           
        
    
    
}
