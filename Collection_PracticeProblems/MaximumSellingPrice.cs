using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_PracticeProblems
{
    internal class MaximumSellingPrice
    {
        public void SellingPrice()
        {
            //Console.WriteLine("Enter N value and K value Separated with Space");
            string[] nk = Console.ReadLine().Split(" ");
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            List<int> priceA=Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> priceB = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            // Sort the prices of apples and bananas in descending order
            priceA.Sort();
            priceA.Reverse();
            priceB.Sort();
            priceB.Reverse();
            // Swap fruits from basket-b to basket-a at most k times if beneficial
            for (int i = 0; i< k;i++)
            {
                if(i>=priceA.Count || i>= priceB.Count || priceA[i] >= priceB[i])
                    break;
                    priceA[i] = priceB[i];
            }
            // Calculate the maximum selling price of basket-a
            int maxPrice = priceA.Sum();
            Console.WriteLine(maxPrice);
        }
    }
}
