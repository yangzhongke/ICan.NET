using ICan.NET;

namespace ICanNetConsoleTest
{
    [TestClass]
    public class UnitTestDefaultValuedDictionary
    {
        [TestMethod]
        public void TestMethodSimpleInt()
        {
            DefaultValuedDictionary<string,int> dict = new (0);
            dict["yzk"]++;
            dict["zack"] = 6;
            dict["zack"]++;
            Assert.AreEqual(dict["yzk"], 1);
            Assert.AreEqual(dict["zack"], 7);
            Assert.IsTrue(dict.ContainsKey("yzk"));
            Assert.IsFalse(dict.ContainsKey("hello"));
        }

        [TestMethod]
        public void TestMethodSimpleString()
        {
            DefaultValuedDictionary<string, string> dict = new("@you");
            Assert.AreEqual(dict["yzk"], "@you");
            dict["hello"] = "world";
            Assert.AreEqual(dict["hello"], "world");
        }

        [TestMethod]
        public void TestMethodValueProvider()
        {
            DefaultValuedDictionary<int, int> dict = new(key => key*2);
            Assert.AreEqual(dict[1], 2);
            Assert.AreEqual(dict[2], 4);
        }
    }
}