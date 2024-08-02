namespace MoneyExtension.tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor=279.98M;
        int cents = valor.ToCents();

        Assert.AreEqual(expected:27998,actual:cents);

    }
}