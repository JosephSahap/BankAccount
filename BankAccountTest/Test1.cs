using BankAccount;
namespace BankAccountTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestInitialBalance()
    {
        var account = new BankAccount.BankAccount("Joseph", 100);
        var balance = account.Balance;
        Assert.AreEqual(100, balance);
    }
}
//test2