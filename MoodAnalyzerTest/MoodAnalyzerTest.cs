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
        public void given_Null_Mood_Should_Throw_MoodAnalyserCustomException_Indocating_NullMood()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Console.WriteLine("Mood should not be null", e.Message);
            }
        }

        [TestMethod]
        public void given_Empty_Mood_Should_Throw_MoodAnalyserCustomException_Indocating_Empty_Mood()
        {
            try
            {
                string message = "";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Console.WriteLine("Mood should not be Empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_Should_Return_MoodAnalyser_Object()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer","");
            expected.Equals(obj);
        }

        [TestMethod]
        public void Given_MoodAnalyser_ClassName_ImproperShould_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyzer();
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalys", "MoodAnalyzer","");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        [TestMethod]
        public void Given_MoodAnalyser_Method_Name_Improper_Should_Throw_MoodAnalyserExceptio()
        {
            try
            {
                object expected = new MoodAnalyzer();
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAr", "Mood","");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parameeterized_ConstrctrutorImproper()
        {
            try
            {
                object expected = new MoodAnalyzer("Happy");
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyzer("Happy");
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyr", "MoodAnalyzer", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Given_MoodAnalyser_Method_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyzer("Happy");
                object obj = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnal", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}