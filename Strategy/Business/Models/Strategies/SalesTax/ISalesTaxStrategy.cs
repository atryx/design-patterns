namespace Strategy_Pattern_First_Look.Business.Models.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFox(Order order);
    }
}
