using MoodAnalyzerProblem;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenGivenSadMessage_shouldReturnSad()
        {
            try
            {
                string message = MoodAnalyzer.AnalyseMood("i am sad");
                Assert.AreEqual("Sad", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void WhenGivenHappyMessage_shouldReturnHappy()
        {
            try
            {
                string message = MoodAnalyzer.AnalyseMood("i am in any Mood");
                Assert.AreEqual("Happy", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}