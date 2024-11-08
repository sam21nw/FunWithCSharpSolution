namespace Employees;
internal class BenefitPackage
{
    public enum BenefitPackageLevel
    {
        Standard, Gold, Platinum
    }
    public double ComputePayDeduction()
    {
        return 125.0;
    }
}
