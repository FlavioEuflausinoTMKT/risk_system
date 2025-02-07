using RiskSystem.Domain.Interfaces;
using RiskSystem.Domain.Enums;

namespace RiskSystem.Domain.Rules
{
    public class ExpiredTradeRule : IRiskCategoryRule
    {
        public bool IsApplicable(ITrade trade, DateTime referenceDate)
        {
            return trade.NextPaymentDate < referenceDate;
        }

        public RiskCategory GetCategory()
        {
            return RiskCategory.EXPIRED;
        }
    }
}