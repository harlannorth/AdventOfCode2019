using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge1;
using System;
using System.Diagnostics;

namespace Challenge1Test
{
    [TestClass]
    public class IntercodeTests
    {

        private Intcode _intcode;

        [TestInitialize]
        public void Init()
        {
            _intcode = new Intcode();
        }

        [TestMethod]
        public void TestRunWith99()
        {
            var result = _intcode.RunIntCode(new int[] {99});

            Assert.AreEqual(99,result[0]);
        }

        //1,0,0,0,99
        [TestMethod]
        public void TestRunWithOneResult()
        {
            var result = _intcode.RunIntCode(new int[] {1,0,0,0,99});
            Assert.AreEqual(2,result[0]);
        }

        //1,1,1,4,99,5,6,0,99
        [TestMethod]
        public void TestRunWithTwoResults()
        {
            var result = _intcode.RunIntCode(new int[] {1,1,1,4,99,5,6,0,99});
            Assert.AreEqual(30,result[0]);
            Assert.AreEqual(2,result[4]);
        }

        //2,3,0,3,99
        [TestMethod]
        public void TestRunWithOneMidResult()
        {
            var result = _intcode.RunIntCode(new int[] {2,3,0,3,99});
            Assert.AreEqual(6,result[3]);
        }

        [TestMethod]
        public void TestRunWithOneEndResult()
        {
            var result = _intcode.RunIntCode(new int[] {2,4,4,5,99,0});
            Assert.AreEqual(9801,result[5]);
        }

        [TestMethod]
        public void TestParse()
        {
            var program = _intcode.ParseInput("1,2,3,");
            Assert.IsNotNull(program);
            Assert.AreEqual(1,program[0]);
            Assert.AreEqual(3,program[2]);
        }

        [TestMethod]
        public void PerformOperationOneTest()
        {
            var result = _intcode.PerformOperationOne(0, new int[] {1,9,10,3,2,3,11,0,99,30,40,50});
            Assert.AreEqual(70,result[3]);
        }

        [TestMethod]
        public void PerformOperationTwoTest()
        {
            var result = _intcode.PerformOperationTwo(0, new int[] {2,9,10,3,2,3,11,0,99,30,40,50});
            Assert.AreEqual(1200,result[3]);
        }
    }
}
