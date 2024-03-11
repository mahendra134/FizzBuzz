namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string[] GenerateFizzBuzz(int start, int end)
        {
            string[] output = new string[end - start + 1];
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output[i - start] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    output[i - start] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    output[i - start] = "Buzz";
                }
                else
                {
                    output[i - start] = i.ToString();
                }
            }
            return output;
        }
    }
}
