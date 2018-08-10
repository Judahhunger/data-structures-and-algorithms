using MultiBracketValidation;
using System;
using Xunit;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}", true)]
        [InlineData("{}(){}", true)]
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("(){}[[]]", true)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("[({}]", false)]
        [InlineData("(](", false)]
        [InlineData("{(})", false)]
        public void Test1(string userString, bool userBool)
        {
            bool resultsBool = Program.ValidationBrackets(userString);
            Assert.Equal(userBool, resultsBool);
        }
    }
}
