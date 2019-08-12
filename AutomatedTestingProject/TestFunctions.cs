using NUnit.Framework;
using AutomatedTestLibrary;

namespace Tests {
    public class TestsFunctions {

        Functions functions = null;

        [SetUp]
        public void Setup() {

            functions = new Functions();
        }

        [Test]
        public void Test1() {
            var answer = functions.Add1(0);
            Assert.AreEqual(1, answer);
            answer = functions.Add1(-1);
            Assert.AreEqual(0, answer);
        }
        [Test]
        public void TestXSquaredPlus3() {
            //test input 0
            var ans = functions.XSquaredPlus3(0);
            Assert.AreEqual(3, ans);
            // test input 3
            ans = functions.XSquaredPlus3(3);
            Assert.AreEqual(12, ans);
        }


        //[Test]
        //public void Test1() {
        //    var answer = functions.Add1(3);
        //    Assert.AreEqual(4, answer);
        //}

        //[Test]
        //public void Test2() {
        //    var answer = functions.Add1(3);
        //    Assert.AreNotEqual(3, answer);
        //}

    }
}