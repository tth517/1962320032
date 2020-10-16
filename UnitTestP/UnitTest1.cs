using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
namespace UnitTestP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int A = 0;
            int B = 0;
            int X = 0;
            Class1 cl = new Class1(A, B, X);
            Assert.IsNotNull(cl);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int A = 3;
            int B = 1;
            int X = 0;
            Class1 cl = new Class1(A, B, X);
            Assert.IsNotNull(cl);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int A = 2;
            int B = 0;
            int X = 0;
            Class1 cl = new Class1(A, B, X);
            Assert.IsNotNull(cl);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int A = 2;
            int B = 1;
            int X = 0;
            Class1 cl = new Class1(A, B, X);
            Assert.IsNotNull(cl);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int A = 3;
            int B = 1;
            int X = 0;
            Class1 cl = new Class1(A, B, X);
            Assert.IsNotNull(cl);
        }
    }
}
