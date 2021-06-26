using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketsBalanceVerefication.Tests
{
    [TestClass]
    public class BalanceTest
    {
        [TestMethod]
        public void BracketsBalance()
        {
            char[] array = new char[6] { '(', '{', '[', ']', '}', ')' };
            string expected = "Not Balanced";

            BalanceVerificator balanceVerificator = new BalanceVerificator();
            string actual = balanceVerificator.
        }
    }
}
