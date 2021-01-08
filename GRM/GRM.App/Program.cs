﻿using System;
using System.Linq;

namespace GRM.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();

            Console.WriteLine("Enter Patner Name");

            var partnerName = Console.ReadLine();

            var partner = dataService
                .GetPartners()
                .Single(_ => _.Name.Equals(partnerName, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine("Enter Effective Date");

            var effectiveDateEntered = Console.ReadLine();
                 
            if (DateTime.TryParse(effectiveDateEntered, out var effectiveDate)) 
            {
                effectiveDate = DateTime.Now;
            }

            var partnerService = new PartnerService(partner, dataService);

            var data = partnerService.GetAvailableProducts(effectiveDate);

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Artist}, {item.Title}, {item.Usages}, {item.StartDate}, {item.EndDate}");
            }
        }
    }
}
