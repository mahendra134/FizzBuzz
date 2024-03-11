namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string[] GetFizzBuzzArray(string[] values)
        {
            List<string> result = new List<string>();

            foreach (var value in values)
            {
                if (int.TryParse(value, out int intValue))
                {
                    result.Add(FizzBuzz(intValue));
                }
                else
                {
                    result.Add("Invalid Item");
                }
            }

            return result.ToArray();
        }

        private string FizzBuzz(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
                return "FizzBuzz";
            else if (value % 3 == 0)
                return "Fizz";
            else if (value % 5 == 0)
                return "Buzz";
            else
                return value.ToString();
        }
    }
}
