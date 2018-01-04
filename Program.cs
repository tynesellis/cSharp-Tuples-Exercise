using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
        {
            ("hammer", 10.99, 1),
            ("box of nails", 8.99, 1),
            ("box of bandaids", 12.99, 1),
            ("Bottled Cokes", 1.29, 3),
            ("saw", 14.99, 1),
        };
            int sales = 0;
            double salesTotal = 0;
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                sales += t.quantity;
                salesTotal += t.amount;
            }
            Console.WriteLine($"Items sold today: {sales}");
            Console.WriteLine($"Total revenue: {salesTotal}");
        }
    }
}
