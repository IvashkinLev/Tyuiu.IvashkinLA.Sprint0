using Tyuiu.IvashkinLA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.IvashkinLA.Sprint0.Task4.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedAdditionValid()
        {
            Assert.That(DataService.Addition(5, 5), Is.EqualTo(10));
        }

        [Test]
        public void CheckedSubstractionValid()
        {
            Assert.That(DataService.Subtraction(10, 5), Is.EqualTo(5));
        }

        [Test]
        public void CheckedMultiplicationValid()
        {
            Assert.That(DataService.Multiplication(5, 5), Is.EqualTo(25));
        }

        [Test]
        public void CheckedDivisionValid()
        {
            Assert.That(DataService.Division(10, 5), Is.EqualTo(2));
        }
    }
}