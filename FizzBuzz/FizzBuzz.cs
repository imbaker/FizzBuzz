namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string Process(int index)
        {
            if (index < 1 || index > 100)
                throw new ArgumentOutOfRangeException("index");
            
            if (index % 3 == 0 && index % 5 == 0)
                return "FizzBuzz";

            if (index % 3 == 0)
                return "Fizz";

            if (index % 5 == 0)
                return "Buzz";

            return index.ToString();
        }
    }
}
