using System.Runtime.ExceptionServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var first = 1;
            var second = 2;

            // act
            var actual = this.add(first, second);
            
            // assert
            var expected = 3;
            Assert.AreEqual(actual, expected);

        }

        private int add(in int first, in int second)
        {
            return first + second;
        }
    }
}