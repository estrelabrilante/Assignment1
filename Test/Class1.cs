using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        Rectangle r = new Rectangle();
        
        [Test]
        public void TestGetLength()
        {
            //Arrange 
          


            //Act
            int result = r.GetLength();

            //Assert
            Assert.AreEqual(1,result,1);
           
        }
        [Test]
        public void SetLengthTest()
        {
            //Arrange 

            //Act
            int result = r.SetLength(6);

            //Assert
            Assert.AreEqual(6, result, 1);
        }
        [Test]
        public void GetWidthTest()
        {
            //Arrange 

            //Act
            int result = r.GetWidth();
            //Assert
            Assert.AreEqual(1, result, 1);

        }
        [Test]
        public void SetWidthTest()
        {

            //Arrange 

            //Act
            int result = r.SetWidth(5);

            //Assert
            Assert.AreEqual(5, result, 1);
        }
        [Test]
        public void GetPerimeterTest()
        {
            //Arrange 

            //Act
            int result = r.GetPerimeter();
            //Assert
            Assert.AreEqual(4, result, 1);
        }
        [Test]
        public void GetAreaTest()
        {
            //Arrange 

            //Act
            int result = r.GetArea();
            //Assert
            Assert.AreEqual(1, result, 1);

        }



    }
}
