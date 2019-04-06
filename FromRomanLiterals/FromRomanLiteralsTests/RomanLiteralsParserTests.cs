using FromRomanLiterals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromRomanLiteralsTests
{
    [TestClass]
    public class RomanLiteralsParserTests
    {
        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("IX", 9)]
        [DataRow("XLII", 42)]
        [DataRow("XCIX", 99)]
        [DataRow("MMXIII", 2013)]
        public void ParserRomanLiteral_RomanLiteral_CorrectArabianNumber(string romanLiteral, int expectedResult)
        {
            #region ARRANGE

            #endregion

            #region ACT

            int result = RomanLiteralsParser.ConvertRomanLiteralToInt(romanLiteral);

            #endregion

            #region ASSERT

            Assert.AreEqual(expectedResult, result);

            #endregion
        }
    }
}
