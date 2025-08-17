
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    [TestFixture]
    public class ArrayUnitTest
    {
        [Test]

       public void TestArrayNames()
        {
            // Arrange
            var Names = new string[] { "Ahmed", "Ali", "Sara", "Fatima", "Omar", "Layla", "Hassan", "Zainab", "Youssef", "Aisha" };

            // Assert.That(Names,Does.Contain("Ali").IgnoreCase);
            //Assert.That(Names,Is.Unique);
            //Assert.That(Names, Has.Exactly(2).EqualTo("Ahmed"));
            Assert.That(Names, Has.Length.EqualTo(10));

          
            
        }
        [Test]
        [Ignore("ignore This Function ")]
        public void TestArray()
        {
            // Arrange
            var Names = new string[] { "Ahmed", "Ali", "Sara", "Fatima", "Omar", "Layla", "Hassan", "Zainab", "Youssef", "Aisha" };

            // Assert.That(Names,Does.Contain("Ali").IgnoreCase);
            //Assert.That(Names,Is.Unique);
            //Assert.That(Names, Has.Exactly(2).EqualTo("Ahmed"));
            Assert.That(Names, Has.Length.EqualTo(10));



        }



    }
   
}
