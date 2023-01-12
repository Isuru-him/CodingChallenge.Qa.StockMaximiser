namespace CodingChallenge.Qa.StockMaximiser;

public interface IMaximiser
{
    decimal Max(List<decimal> stockPrices);

    int[] profitMax(int[] stockPrices);
}