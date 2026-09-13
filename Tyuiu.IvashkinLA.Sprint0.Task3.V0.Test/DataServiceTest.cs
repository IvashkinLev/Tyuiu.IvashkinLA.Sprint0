using Tyuiu.IvashkinLA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.IvashkinLA.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedValid()
        {
            Assert.That(DataService.Sum(5, 5), Is.EqualTo(10));
        }
    }
}