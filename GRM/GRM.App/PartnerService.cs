using System;
using System.Collections.Generic;

namespace GRM.App
{
    public class PartnerService
    {
        public PartnerService(string partnerName, IDataService dataService)
        {
            PartnerName = partnerName;
        }

        public string PartnerName { get; }

        public IEnumerable<Data> GetAvailableProducts(DateTime date)
        {
            return new Data[0];
        }
    }
}
