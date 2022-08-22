using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzerProblem
{
    public class MoodAnalayserFactory
    {
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