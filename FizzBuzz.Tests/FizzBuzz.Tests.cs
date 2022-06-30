namespace FizzBuzz.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        static int[] ValidIndexNumbers = new int[] { 1, 2, 4, 7, 8, 11, 13, 14 };
        static int[] ByThreeNumbers = new int[] { 3, 6, 9, 12 };
        static int[] ByFiveNumbers = new int[] { 5, 10, 20, 25, 100 };
        static int[] ByThreeAndFiveNumbers = new int[] { 15, 30, 45, 60, 75, 90 };

        [Test, TestCaseSource(nameof(ValidIndexNumbers))]
        public void WhenValidIndexProvided_ReturnIndex(int index)
        {
            var sut = FizzBuzz.Process(index);
            Assert.That(sut, Is.EqualTo(index.ToString()));
        }

        [Test, TestCaseSource(nameof(ByThreeNumbers))]
        public void WhenIndexProvidedDivisibleByThree_ReturnFizz(int index)
        {
            var sut = FizzBuzz.Process(index);
            Assert.That(sut, Is.EqualTo("Fizz"));
        } 

        [Test, TestCaseSource(nameof(ByFiveNumbers))]
        public void WhenIndexProvidedDivisibleByFive_ReturnBuzz(int index)
        {
            var sut = FizzBuzz.Process(index);
            Assert.That(sut, Is.EqualTo("Buzz"));
        }

        [Test, TestCaseSource(nameof(ByThreeAndFiveNumbers))]
        public void WhenIndexProvidedDivisibleByThreeAndFive_ReturnFizzBuzz(int index)
        {
            var sut = FizzBuzz.Process(index);
            Assert.That(sut, Is.EqualTo("FizzBuzz"));
        }

        [TestCase(0)]
        [TestCase(101)]
        public void WhenIndexProvidedOutOfRange_ThrowException(int index)
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate { var sut = FizzBuzz.Process(index); });
        }

    }
}