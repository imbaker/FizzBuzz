namespace FizzBuzz
{
    using System.Text;

    public static class FizzBuzz
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public static string Process(int index)
        {
            if (index < 1 || index > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var response = new StringBuilder();
            
            if (index % 3 == 0)
            {
                response.Append(Fizz);
            }

            if (index % 5 == 0)
            {
                response.Append(Buzz);
            }

            if (string.IsNullOrEmpty(response.ToString()))
            {
                response.Append(index);
            }

            return response.ToString(); 
        }
    }
}
