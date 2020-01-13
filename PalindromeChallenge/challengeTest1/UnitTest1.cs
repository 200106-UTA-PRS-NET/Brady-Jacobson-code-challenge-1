using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge;

namespace challengeTest1
{
    [TestClass]
    public class UnitTest1
    {
        PalindromeClass p = new PalindromeClass();
        [TestMethod]
        public void TestMethod1()
        {
            bool r = p.checkPalindrome("nurses run");
            Assert.IsTrue(r);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool r = p.checkPalindrome("racecaR");
            Assert.IsTrue(r);
        }
        [TestMethod]
        public void TestMethod3()
        {
            bool r = p.checkPalindrome("1221");
            Assert.IsTrue(r);
        }
        [TestMethod]
        public void TestMethod4()
        {
            bool r = p.checkPalindrome("never odd, or even");
            Assert.IsTrue(r);
        }
        [TestMethod]
        public void TestMethod5()
        {
            bool r = p.checkPalindrome("one two one");
            Assert.IsFalse(r);
        }
        [TestMethod]
        public void TestMethod6()
        {
            bool r = p.checkPalindrome("123abccba123");
            Assert.IsFalse(r);
        }
        [TestMethod]
        public void TestMethod7()
        {
            bool r = p.checkPalindrome("so i said i as i os");
            Assert.IsTrue(r);
        }
    }
}
