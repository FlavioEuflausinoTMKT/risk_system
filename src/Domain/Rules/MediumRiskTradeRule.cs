using RiskSystem.Domain.Interfaces;
using RiskSystem.Domain.Enums;

namespace RiskSystem.Domain.Rules
{
    public class MediumRiskTradeRule : IRiskCategoryRule
    {
        public bool IsApplicable(ITrade trade, DateTime referenceDate)
        {
            return trade.Value > 1000000 && trade.ClientSector.Equals("Public", StringComparison.OrdinalIgnoreCase);
        }

        public RiskCategory GetCategory()
        {
            return RiskCategory.MEDIUMRISK;
        }
    }
} 