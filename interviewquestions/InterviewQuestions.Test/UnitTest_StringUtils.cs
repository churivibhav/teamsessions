using System;
using System.Text;
using Xunit;

namespace InterviewQuestions.Test
{
    public class UnitTest_StringUtils
    {
        [Fact]
        public void Test_ReverseString()
        {
            // Input
            string str = "ABC";
            // Call
            var reversed = StringUtils.Reverse(str);
            // Assert -> Output == Expected ?
          

            StringBuilder b = new StringBuilder();
            b.Append("Akshay")
                .Append("Ashish");

            b.Append("ABCBJCKSBKCBSKJB");
            Assert.Equal("AkshayAshish", b.ToString());

            Assert.Equal("CBA", reversed);
        }
    }
}
