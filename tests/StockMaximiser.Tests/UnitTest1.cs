using CodingChallenge.Qa.StockMaximiser;
using Xunit;

namespace StockMaximiser.Tests;

public class UnitTest1
{
    [Fact]
    public void validateMaximumProfit()
    {
        Maximiser maximiser = new Maximiser();

        int[] sharePrices;
        int[] results;

        sharePrices = new int[] {7,1,5,3,6,4};

        results= maximiser.profitMax(sharePrices);

        Assert.Equal(5, results[0]);

        /* first testcase is used to show an example where a person can make a maximum profit
         * according to this array of prices which is given as an input to the method gives a 
         * max profit when you buy it on the 2nd day and sell it on the 5th day
         * max profit is only validated in this testcase. 
         */
    }

    [Fact]
    public void ValidateZeroProfit()
    {
        Maximiser maximiser = new Maximiser();

        int[] sharePrices;
        int[] results;
        sharePrices = new int[] { 7,6,4,3,1};

        results = maximiser.profitMax(sharePrices);

        Assert.Equal(0, results[0]);

        /* second testcase is used to show an example where a person can't make any profit
         * because all the values in the array are in a descending order hence you can only
         * end up in a lost 
         * therefore via testcase to show the profit is 0, that has been validated. TDDDDDDDDDDD
         */
    }
}