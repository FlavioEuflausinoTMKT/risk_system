using RiskSystem.Domain.Interfaces;
using RiskSystem.Domain.Enums;

namespace RiskSystem.Domain.Rules
{
    public interface IRiskCategoryRule
    {
        bool IsApplicable(ITrade trade, DateTime referenceDate);
        RiskCategory GetCategory();
    }
}