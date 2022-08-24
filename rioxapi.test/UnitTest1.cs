using Microsoft.AspNetCore.Mvc;
using rioxapi.Controllers;
using System;
using Xunit;

namespace rioxapi.test
{
    public class UnitTest1
    {
        [Fact]
        public void GetReturnsRiox()
        {
            var controller = new ValuesController();
            var result = controller.Get();

            var value = Assert.IsType<OkObjectResult>(result).Value;
            Assert.Equal("rampage !", value.ToString());
        }
    }
}
