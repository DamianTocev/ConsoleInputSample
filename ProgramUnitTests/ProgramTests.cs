using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ProgramUnitTests
{
    public class ProgramTests
    {
        [Test]
        public void Test_ProgramSum_ThreePositiveNumbers()
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
            var expectedResult = "The sum is: " + Environment.NewLine + "27" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_ProgramSum_TwoPositiveNumbers()
        {
            // Arrange
            string input = "10 12";
            var writer = new StringWriter();
            Console.SetOut(writer); // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            // Act
            ConsoleInputSample.ProgramTest.Main();

            // Assert
            var actualResult = writer.ToString();
            var expectedResult = "The sum is: " + Environment.NewLine + "22" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_ProgramSum_OnePositiveNumbers()
        {
            // Arrange
            string input = "5";
            var writer = new StringWriter();
            Console.SetOut(writer); // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            // Act
            ConsoleInputSample.ProgramTest.Main();

            // Assert
            var actualResult = writer.ToString();
            var expectedResult = "The sum is: " + Environment.NewLine + "5" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_ProgramSum_ThreeNegativeNumbers()
        {
            // Arrange
            string input = "-5 -10 -12";
            var writer = new StringWriter();
            Console.SetOut(writer); // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            // Act
            ConsoleInputSample.ProgramTest.Main();

            // Assert
            var actualResult = writer.ToString();
            var expectedResult = "The sum is: " + Environment.NewLine + "-27" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test_ProgramSum_OnePositive_And_TwoNegative_Numbers()
        {
            // Arrange
            string input = "5 -10 -12";
            var writer = new StringWriter();
            Console.SetOut(writer); // Redirect Console.Out

            var reader = new StringReader(input);
            Console.SetIn(reader); // Redirect Console.In

            // Act
            ConsoleInputSample.ProgramTest.Main();

            // Assert
            var actualResult = writer.ToString();
            var expectedResult = "The sum is: " + Environment.NewLine + "-17" + Environment.NewLine;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}