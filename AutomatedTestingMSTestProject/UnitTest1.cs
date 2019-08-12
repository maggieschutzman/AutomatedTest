using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedTestLibrary;

namespace AutomatedTestingMSTestProject {

    [TestClass]
    public class TestsFunctions {

        Functions functions = null;

        [TestInitialize]
        public void Setup() {
            functions = new Functions();
        }

        [TestMethod]
        public void Test1() {
            var answer = functions.Add1(0);
            Assert.AreEqual(1, answer);
            answer = functions.Add1(-1);
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void Test2() {
            var answer = functions.Add1(3);
            Assert.AreEqual(4, answer);
        }

        [TestMethod]
        public void Test3() {
            var answer = functions.Add1(3);
            Assert.AreNotEqual(3, answer);
        }

        [TestMethod]
        public void TestXSquaredPlus3() {
            //test input 0
            var ans = functions.XSquaredPlus3(0);
            Assert.AreEqual(3, ans);
            // test input 3
            ans = functions.XSquaredPlus3(3);
            Assert.AreEqual(12, ans);
        }

        [TestMethod]
        public void DividedBy3() {
            var an = functions.DividedBy3(3);
            Assert.AreEqual(1, an);
        }

        [TestMethod]
        public void Multiplyby4() {
            var a = functions.Multiplyby4(5);
            Assert.AreEqual(20, a);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void X7X12() {
            // test zero
            var b = functions.X7X12(0);
            Assert.AreEqual(12, b);
            // test one
            var d = functions.X7X12(1);
            Assert.AreEqual(6, d);
            //test neg 1
            //Assert.AreEqual(20, functions.X7X12(-1));
            Assert.AreEqual(0, functions.X7X12(4));
        }

    }
}

