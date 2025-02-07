using RiskSystem.Domain.Rules;
using RiskSystem.Services;
using RiskSystem.Domain.Entities;
using RiskSystem.Domain.Interfaces;

var rules = new List<IRiskCategoryRule>
{
    new PEPTradeRule(),
    new ExpiredTradeRule(),
    new HighRiskTradeRule(),
    new MediumRiskTradeRule()
};

var analyzer = new RiskAnalyzer(rules);

var referenceDate  = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

var numberOfTrades = int.Parse(Console.ReadLine());


for (int i = 0; i < numberOfTrades; i++)
{
    var input = Console.ReadLine().Split(' ');
    var trade = new Trade
    {
        Value = double.Parse(input[0]),
        ClientSector = input[1],
        NextPaymentDate = DateTime.ParseExact(input[2], "MM/dd/yyyy", null),
        IsPoliticallyExposed = bool.Parse(input[3])
    };

    var category = analyzer.CategorizeTrade(trade, referenceDate);
    Console.WriteLine(category);
}