using System;
using System.Linq;

namespace InterviewQuestions
{
    public class StringUtils
    {
        public static string Reverse(string str)
        {
            return string.Join(string.Empty, str.ToCharArray().Reverse());
        }
    }
}
