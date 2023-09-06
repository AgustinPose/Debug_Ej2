using TestDateFormat;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormatoCorrecto()
    {
        string date = "06/09/2023";
        string expected = "2023-09-06";
        string output = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(output, expected);
    }
    [Test]
    public void MalFormato()
    {
        string date = "06/2023";
        string expected = "2023-09-06";
        string output = DateFormatter.ChangeFormat(date);
        Assert.AreNotEqual(output, expected);
    }

        [Test]
    public void Vacio()
    {
        string date = "";
        string expected = "error";
        string output = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(expected ,output);
    }
}