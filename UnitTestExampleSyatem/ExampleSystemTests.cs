using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExampleSystem;

namespace UnitTestExampleSyatem
{
    [TestClass]
    public class ExampleSyatemUnitTests
    {
        [TestMethod]
        public void Model_Initialize_Verify()
        {
            int expectedValue = 5;
            Model sut = new Model() { Counter=expectedValue };

            Assert.AreEqual(sut.Counter, expectedValue);
        }

        [TestMethod]
        public void ViewModel_Initialize_Verify()
        {
            ViewModel sut = new ViewModel();

            Assert.AreEqual(sut.Label, 0);

            sut.Model.Counter = 10;
            Assert.AreEqual(sut.Model.Counter, 10);

        }

        [TestMethod]
        public void Command_Execute_Verify()
        {
            ViewModel sut = new ViewModel();

            sut.command.Execute(this);
            Assert.AreEqual(sut.Label, 1);

        }
    }
}
