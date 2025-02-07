using RiskSystem.Domain.Enums;
using RiskSystem.Domain.Interfaces;
using RiskSystem.Domain.Rules;

namespace RiskSystem.Services
{
    public class RiskAnalyzer
    {
        private readonly List<IRiskCategoryRule> _rules;

        public RiskAnalyzer(List<IRiskCategoryRule> rules)
        {
            _rules = rules;
        }

        public RiskCategory CategorizeTrade(ITrade trade, DateTime referenceDate)
        {
            foreach (var rule in _rules)
            {
                if (rule.IsApplicable(trade, referenceDate))
                {
                    return rule.GetCategory();
                }
            }
            
            throw new Exception("No categories found for this trade");
        }
    }
}