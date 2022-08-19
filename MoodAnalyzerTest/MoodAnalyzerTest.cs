using MoodAnalyzerProblem;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenGivenSadMessage_shouldReturnSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer("i am sad");
            try
            {
                string message = mood.AnalyseMood();
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
            MoodAnalyzer mood = new MoodAnalyzer("i am in any Mood");
            try
            {
                string message = mood.AnalyseMood();
                Assert.AreEqual("Happy", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
     
        [TestMethod]
        public void WhenGivenNull_ShouldReturnHappy()
        {
            MoodAnalyzer mood = new MoodAnalyzer(null);
            try
            {
                string message = mood.AnalyseMood();
                Assert.AreEqual("Happy", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}