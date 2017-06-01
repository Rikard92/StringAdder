using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringAdder;

namespace StringAdderTest
{
    [TestFixture]
    class AditionTest
    {
        private Adition sut;

        [SetUp]
        public void AditionTestSetup()
        {
            sut = new Adition();
        }

        [Test]
        public void Add1()
        {
            //Arrange
            int ret;

            //Act
            ret=sut.Add("");


            //Assert
            Assert.AreEqual(0, ret);

        }

        [Test]
        public void Add2()
        {
            //Arrange
            int ret;

            //Act
            ret = sut.Add("1");


            //Assert
            Assert.AreEqual(1, ret);

        }

        [Test]
        public void Add3()
        {
            //Arrange
            int ret;

            //Act
            ret = sut.Add("1,2");


            //Assert
            Assert.AreEqual(3, ret);

        }

        [Test]
        public void Add4()
        {
            //Arrange
            int ret;

            //Act
            ret = sut.Add("1,2,3");


            //Assert
            Assert.AreEqual(6, ret);

        }

        [Test]
        public void Add5()
        {
            //Arrange
            int ret;

            //Act
            ret = sut.Add("1\n2");


            //Assert
            Assert.AreEqual(3, ret);

        }

        [Test]
        public void Add6()
        {
            //Arrange
            int ret;

            //Act
            ret = sut.Add("1\n2,3");


            //Assert
            Assert.AreEqual(6, ret);

        }

        [Test]
        public void Add7()
        {
            //Arrange
            int ret;

            //Act
            ret = sut.Add("-1,2");


            //Assert
            Assert.AreEqual(1, ret);

        }

    }
}
