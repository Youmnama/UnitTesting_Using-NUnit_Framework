using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UnitTesting;

namespace Employee_Test
{
    [TestFixture]
    public class Employee_Unit_Test
    {
        Employee employee;
        [SetUp]
        public void Setup()
        {
            // This method will run before each test
            employee = new Employee();
        }
        //[Test]
        //public void IsAdultTest30()
        //{



        //    // Act
        //    var result = employee.IsAdult(30);

        //    // Assert
        //    Assert.That(result,Is.EqualTo(false) );
        //}
        //[Test]
        //public void IsAdultTest70()
        //{



        //    // Act
        //    var result = employee.IsAdult(70);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(true));
        //}
        //[Test]
        //[TestCase(30, false)]
        //[TestCase(70, true)]
        //[TestCase(60, true)]

        //public void IsAdultTest(int age, bool Expectedvalue)
        //{



        //    // Act
        //    var result = employee.IsAdult(age);

        //    // Assert
        //    Assert.That(result, Is.EqualTo(Expectedvalue));
        //}

        [Test]
        [TestCaseSource(typeof(TestData))]
        public bool IsAdultTest(int age)
        {
            return employee.IsAdult(age);


        
        }
        public class TestData: IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                //yield return new object[] { 30, false };
                //yield return new object[] { 70, true };
                //yield return new object[] { 60, true };

                StreamReader r = new StreamReader("UnitTesting/Employee.json");
                string json = r.ReadToEnd();
                List<EmployeeTestCaseData> item = JsonConvert.DeserializeObject<List<EmployeeTestCaseData>>(json);   
                foreach (var data in item)
                {
                    yield return new TestCaseData(data.Age).Returns(data.expectedresult);
                }

            }


        }


    }
}
