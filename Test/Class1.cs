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
        public void GetLengthTest()
        {          
            int i = 5; //Arrange 
            int result = r.GetLength(); //Act
            Assert.AreEqual(i, result, 1);//Assert

        }
        [Test]
        public void SetLengthTest()
        {
           
            int i = 6; //Arrange 
            int result = r.SetLength(6);  //Act
            Assert.AreEqual(i, result, 1); //Assert
        }
        [Test]
        public void GetWidthTest()
        {         
            int j = 6;//Arrange 
            int result = r.GetWidth();//Act
            Assert.AreEqual(j, result, 1); //Assert
        }
        [Test]
        public void GetWidthTest2()
        {
            int w = 9;    //Arrange 
            int result = r.GetWidth(); //Act
            Assert.AreNotEqual(w, result); //Assert
        }


        [Test]
        public void SetWidthTest()
        {          
            int w = 5;  //Arrange 
            int result = r.SetWidth(5);//Act
            Assert.AreEqual(w, result, 1); //Assert
        }

        [Test]
        public void SetWidthTest1()
        {
            int w = 8;//Arrange 
            int result = r.SetWidth(5);//Act
            Assert.AreNotEqual(w, result);   //Assert
        }
        [Test]
        public void GetPerimeterTest()
        {
           
            int p = 22; //Arrange 
            int result = r.GetPerimeter(); //Act
            Assert.AreEqual(p, result, 1); //Assert
        }
        [Test]
        public void GetPerimeterTest1()
        {
            int p = 16; //Arrange 
            int result = r.GetPerimeter(); //Act
            Assert.AreNotEqual(p, result); //Assert
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

            [Test]
           public void GetAreaTest1()
            {
                //Arrange 

                //Act
                int result1 = r.GetArea();
                //Assert
                Assert.AreNotEqual(1, result1);

            }
             


        }
    } 

