using ConsoleApp1;

namespace StudentTestProject1
{
    public class CalucualtionsTest
    {

        Calculation cal = new Calculation();

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void addTest()
        {
           int ans = cal.add(1, 2);
            Assert.AreEqual(3, ans);
        }
        [Test]
        public void subTest()
        {
            int ans = cal.sub(1, 2);
            Assert.AreEqual(-1, ans);
        }

        [Test]
        public void mulTest()
        {
            int ans = cal.mul(1, 2);
            Assert.AreEqual(2, ans);
        }
        [Test]
        public void divTest()
        {
            int ans = cal.div(1, 2);
            Assert.AreEqual(0.5, ans);
        }

    }
}