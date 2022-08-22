using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzerProblem
{
    public class MoodAnalayserFactory
    {
        public static string InvokedAnalyseMood(string message,string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerProblem.MoodAnalyzer");
                object moodAnalyseObject = MoodAnalayserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", "Happy");
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood=analyseMoodInfo.Invoke(moodAnalyseObject,null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Method is not found");
            }
            {

            }
        }
        public static object CreateMoodAnalyse(string className, string constructorName,string message)
        {
            Type type = typeof(MoodAnalyzer);
            if(type.Name.Equals(className)|| type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance=ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {

                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Contructor is Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
    }
}