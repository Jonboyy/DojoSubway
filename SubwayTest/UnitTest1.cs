using Subway;

namespace SubwayTest;


public class Tests
{

    [Test]
    public void IncomeTest()
    {
        var subway = new Restaurant("MCDONALD");
        var kola = new Drink("Cola");
        subway.AddOrder(kola);
        subway.CalculateIncome();
        Assert.That(subway.Income, Is.EqualTo(4));
    }
}