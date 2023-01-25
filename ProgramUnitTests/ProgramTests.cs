using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ProgramUnitTests
{
    public class ProgramTests
    {
        [Test]
        public void Test_ProgramSum_TwoPositiveNumbers()
        {
            // Arrange
            string input = "5 10 12";
            var writer = new StringWriter();
            Console.SetOut(writer); // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            // Act
            ConsoleInputSample.ProgramTest.Main();

            // Assert
            var actualResult = writer.ToString();
            var expectedResult = "The sum is: " + Environment.NewLine +
                "27" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}