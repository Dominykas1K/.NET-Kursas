using Skaiciuotuvas;

namespace skaiciuotuvo_testai
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double a = 2;
            double b = 3;
            double expected = 5;

            double result = Program.Sudetis(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}