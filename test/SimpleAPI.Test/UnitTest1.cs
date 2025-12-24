// using System;
// using Xunit;
// using SimpleAPI.Controllers;


// namespace SimpleAPI.Test
// {
//     public class UnitTest1
//     {
//         ValuesController controller = new ValuesController();
//         [Fact]
//         public void GetReturnsMyName()
//         {
//             var returnValue = controller.Get(1);
//             Assert.Equal("Finbarr Okeke", returnValue.Value);
//         }



//         [Fact]
//         public void Test1()
//         {

//         }
//     }
// }


using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        
        [Fact]
        public void GetFullName_ReturnsCorrectName()
        {
            var returnValue = controller.GetFullName();
            Assert.Equal("Okeke Tochukwu Finbarr", returnValue.Value);
        }
        
        [Fact]
        public void GetNickname_ReturnsCorrectNickname()
        {
            var returnValue = controller.GetNickname();
            Assert.Equal("The Greek-god", returnValue.Value);
        }
        
        [Fact]
        public void GetById_ReturnsFormattedId()
        {
            var returnValue = controller.GetById(1);
            Assert.Equal("You requested ID: 1", returnValue.Value);
        }
        
        [Fact]
        public void GetAll_ReturnsArray()
        {
            var returnValue = controller.GetAll();
            Assert.NotNull(returnValue.Value);
            Assert.Equal(2, returnValue.Value.Count());
        }
    }
}