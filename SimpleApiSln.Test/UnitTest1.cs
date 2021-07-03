using System;
using Xunit;
using SimpleApiSln.Api.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleApiSln.Test
{


 public class UnitTest1
    {
         
       WeatherForecastController   controller = new WeatherForecastController(null);
       
        [Fact]
        public void Test1()
        {
            var x = controller.Get();
            Assert.Equal("test", "test1");
            
        }


    }
}
