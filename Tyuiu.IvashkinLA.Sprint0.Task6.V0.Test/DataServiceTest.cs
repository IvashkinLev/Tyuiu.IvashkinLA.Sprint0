using Tyuiu.IvashkinLA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.IvashkinLA.Sprint0.Task6.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.That(res, Is.EqualTo(15));
        }

        [Test]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.That(res, Is.EqualTo(-15));
        }

        [Test]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.That(res, Is.EqualTo(120));
        }

    }
}