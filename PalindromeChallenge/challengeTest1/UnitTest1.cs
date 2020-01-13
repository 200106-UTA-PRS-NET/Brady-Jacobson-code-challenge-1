using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge;

namespace challengeTest1
{
    [TestClass]
    public class UnitTest1
    {
        PalindromeClass p = new PalindromeClass();
        //Tests a simple palindrome with a space.
        [TestMethod]
        public void TestMethod1()
        {
            bool r = p.checkPalindrome("nurses run");
            Assert.IsTrue(r);
        }

        //Tests a simple palindrome with capitals.
        [TestMethod]
        public void TestMethod2()
        {
            bool r = p.checkPalindrome("racecaR");
            Assert.IsTrue(r);
        }
        
        //Tests a simple palindrome with numbers
        [TestMethod]
        public void TestMethod3()
        {
            bool r = p.checkPalindrome("1221");
            Assert.IsTrue(r);
        }

        //Tests a simple palindrome with commas
        [TestMethod]
        public void TestMethod4()
        {
            bool r = p.checkPalindrome("never odd, or even");
            Assert.IsTrue(r);
        }

        //Tests a failiure of a palindrome with spelt numbers.
        [TestMethod]
        public void TestMethod5()
        {
            bool r = p.checkPalindrome("one two one");
            Assert.IsFalse(r);
        }

        //Tests a failiure of a palindrome with letters and numbers
        [TestMethod]
        public void TestMethod6()
        {
            bool r = p.checkPalindrome("123abccba123");
            Assert.IsFalse(r);
        }

        //Tests a simple palindrome with random spaces
        [TestMethod]
        public void TestMethod7()
        {
            bool r = p.checkPalindrome("so i said i as i os");
            Assert.IsTrue(r);
        }

        //Tests a simple palindrome with a variety of values that don't count.
        [TestMethod]
        public void TestMethod8()
        {
            bool r = p.checkPalindrome("0#95a.a,59,0,");
            Assert.IsTrue(r);
        }
    }
}
