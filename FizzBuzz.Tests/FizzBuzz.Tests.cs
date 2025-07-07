namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private const string? Fizz = "Fizz";
        private const string? Buzz = "Buzz";
        
        public static TheoryData<int> ValidIndexNumbers => new TheoryData<int> { 1, 2, 4, 7, 8, 11, 13, 14 };
        public static TheoryData<int> InvalidIndexNumbers => new TheoryData<int> { 0, 101 };
        public static TheoryData<int> DivisibleByThreeNumbers => new TheoryData<int> { 3, 6, 9, 12 };
        public static TheoryData<int> DivisibleByFiveNumbers = new TheoryData<int> { 5, 10, 20, 25, 100 };
        public static TheoryData<int> DivisibleByThreeAndFiveNumbers = new TheoryData<int> { 15, 30, 45, 60, 75, 90 };

        [Theory, MemberData(nameof(ValidIndexNumbers))]
        public void Process_When_Valid_Index_Is_Provided_Return_Index(int expectedIndex)
        {
            var sut = FizzBuzz.Process(expectedIndex);
            sut.ShouldBe(expectedIndex.ToString());
        }

        [Theory, MemberData(nameof(DivisibleByThreeNumbers))]
        public void Process_When_Index_Provided_Is_Divisible_By_Three_Return_Fizz(int expectedIndex)
        {
            var sut = CreateSubjectUnderTest(expectedIndex);
            sut.ShouldBe(Fizz);
        }

        [Theory, MemberData(nameof(DivisibleByFiveNumbers))]
        public void Process_When_Index_Provided_Is_Divisible_By_Five_Return_Buzz(int expectedIndex)
        {
            var sut = CreateSubjectUnderTest(expectedIndex);
            sut.ShouldBe(Buzz);
        }
        
        [Theory, MemberData(nameof(DivisibleByThreeAndFiveNumbers))]
        public void Process_When_Index_Provided_Is_Divisible_By_Three_And_Five_Return_FizzBuzz(int expectedIndex)
        {
            var sut = CreateSubjectUnderTest(expectedIndex);
            sut.ShouldBe($"{Fizz}{Buzz}");
        }
        
        [Theory, MemberData(nameof(InvalidIndexNumbers))]
        public void Process_When_Index_Provided_Is_OutOfRange_Throw_ArgumentOutOfRangeException(int actualIndex)
        {
            const string expectedMessage = "Specified argument was out of the range of valid values. (Parameter 'index')";
            Should.Throw<ArgumentOutOfRangeException>(() => CreateSubjectUnderTest(actualIndex))
                .Message.ShouldBe(expectedMessage);
        }
        
        private static string CreateSubjectUnderTest(int expectedIndex) => FizzBuzz.Process(expectedIndex);
    }
}