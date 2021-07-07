using NUnit.Framework;
using WhetherAPI.Controllers;
using WhetherAPI;
using System.Linq;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {

        WeatherForecastController wObject;
      
        [SetUp]  //attribute ,before called run every method
        public void Setup()
        {
            wObject = new WeatherForecastController();
        }

        [Test]   //attribute
        public void Test1()
        {
            var result = wObject.Get();
          //  Assert.AreEqual(result.Count(), 4);
        
 
         }

    [Test] //attribute ,which has special meaning
        public void TestMyAPI()
        {
           
            var result = wObject.Get();
            Assert.AreEqual(result.Count(),5);
        }



    }
}