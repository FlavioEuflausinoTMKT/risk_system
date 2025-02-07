using RiskSystem.Domain.Interfaces;
using RiskSystem.Domain.Enums;

namespace RiskSystem.Domain.Rules
{
    public class PEPTradeRule : IRiskCategoryRule
    {
        public bool IsApplicable(ITrade trade, DateTime referenceDate)
        {
            return trade.IsPoliticallyExposed == true;
        }

        public RiskCategory GetCategory()
        {
            return RiskCategory.PEP;
        }
    }
} 