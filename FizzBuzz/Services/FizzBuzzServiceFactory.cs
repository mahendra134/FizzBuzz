namespace FizzBuzz.Services
{
    public class FizzBuzzServiceFactory : IFizzBuzzServiceFactory
    {
        public IFizzBuzzService CreateFizzBuzzService()
        {
            return new FizzBuzzService();
        }
    }
}
