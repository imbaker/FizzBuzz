namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string Process(int index)
        {
            if (index < 1 || index > 100)
                throw new ArgumentOutOfRangeException("index");

            var response = "";
            
            if (index % 3 == 0)
                response += "Fizz";

            if (index % 5 == 0)
                response += "Buzz";

            return response.Length == 0 ? index.ToString() : response; 
        }
    }
}
