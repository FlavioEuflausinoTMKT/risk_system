using RiskSystem.Domain.Interfaces;
using RiskSystem.Domain.Enums;

namespace RiskSystem.Domain.Rules
{
    public class HighRiskTradeRule : IRiskCategoryRule
    {
        public bool IsApplicable(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1000000 && trade.ClientSector.Equals("Private", StringComparison.OrdinalIgnoreCase);
        }

        public RiskCategory GetCategory()
        {
            return RiskCategory.HIGHRISK;
        }
    }
} 