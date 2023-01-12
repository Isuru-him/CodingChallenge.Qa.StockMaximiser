namespace CodingChallenge.Qa.StockMaximiser;

public class Maximiser : IMaximiser
{
    public decimal Max(List<decimal> stockPrices) => decimal.MinValue;

    public int[] profitMax(int[] stockPrices)
    {
        int maxProfit = 0;
        int buyDay = 0;
        int sellDay = 0;
        
        var details = new int[3];


        for (int a = 0; a < stockPrices.Length; a++)
        {

            for (int b = a + 1; b <= ((stockPrices.Length) - 1); b++)
            {

                if (stockPrices[b] - stockPrices[a] > 0)
                {
                    if (stockPrices[b] > stockPrices[a])
                    {
                        if ((stockPrices[b] - stockPrices[a]) > maxProfit)
                        {
                            maxProfit = stockPrices[b] - stockPrices[a];
                            buyDay = a;
                            sellDay = b;
                            details[0] = maxProfit;
                            details[1] = buyDay + 1;
                            details[2] = sellDay + 1;
                        }

                    }


                }


            }
        }


        return details;
    }

    public decimal[] profitMax(decimal[] stockPrices)
    {
        decimal maxProfit = 0;
        int buyDay = 0;
        int sellDay = 0;

        decimal [] details;
        details = new decimal[3];


        for (int a = 0; a < stockPrices.Length; a++)
        {

            for (int b = a + 1; b <= ((stockPrices.Length) - 1); b++)
            {

                if (stockPrices[b] - stockPrices[a] > 0)
                {
                    if (stockPrices[b] > stockPrices[a])
                    {
                        if ((stockPrices[b] - stockPrices[a]) > maxProfit)
                        {
                            maxProfit = stockPrices[b] - stockPrices[a];
                            buyDay = a;
                            sellDay = b;
                            details[0] = maxProfit;
                            details[1] = buyDay + 1;
                            details[2] = sellDay + 1;
                        }

                    }


                }


            }
        }


        return details;
    }

}