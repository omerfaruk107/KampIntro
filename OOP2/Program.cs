using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCostumer costumer1 = new IndividualCostumer();
            costumer1.CostumerIdNo = "13123123123123";
            costumer1.CostumerName = "Ömer";
            costumer1.CostumerName = "Akdoğan";
            costumer1.CostumerId = 1;

            CoorporateCostumer costumer2 = new CoorporateCostumer();
            costumer2.CostumerId = 12;
            costumer2.CostumerNo = "1234";
            costumer2.CoorporateName = "Nowspacetime LLC";
            costumer2.TaxNo = "234234";

        }
    }
}
