namespace LSP.Solution2;

public interface IDiscountCalculator
{
    public int DiscountPercent { get; set; }
    public decimal CalculateDiscountPrice();
}