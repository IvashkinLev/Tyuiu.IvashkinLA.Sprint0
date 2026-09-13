using Tyuiu.IvashkinLA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IvashkinLA.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            var name = "Лев";
            var res = DataService.GetMessage(name);
            Assert.That(res, Is.EqualTo($"Привет, {name}!"));
        }
    }
}