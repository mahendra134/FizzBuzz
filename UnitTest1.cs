using FizzBuzz.Services;

namespace FizzBuzzNunitTest
{
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService _fizzBuzzService;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        public void GetFizzBuzzArray_ReturnsInvalidItem_ForNonIntegerString()
        {
            
            string[] values = { "1", "2", "Fizz", "10", "null", "15" };
            string[] expected = { "1", "2", "Invalid Item","Buzz", "Invalid Item", "FizzBuzz" };
            string[] result = _fizzBuzzService.GetFizzBuzzArray(values);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzzArray_ReturnsValidFizzBuzzArray_ForAllIntegers()
        {
            string[] values = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
          string[] expected = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" };
            string[] result = _fizzBuzzService.GetFizzBuzzArray(values);
            Assert.AreEqual(expected, result);
        }
    }
}