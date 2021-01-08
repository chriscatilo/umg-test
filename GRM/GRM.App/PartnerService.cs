using System;
using System.Collections.Generic;
using System.Linq;

namespace GRM.App
{
    public class PartnerService
    {
        public PartnerService(Partner partner, IDataService dataService)
        {
            Partner = partner;
            DataService = dataService;
        }

        public Partner Partner { get; }

        public IDataService DataService { get; }

        public IEnumerable<Data> GetAvailableProducts(DateTime date)
        {
            var filtered = DataService.ReadData()
                .Where(_ => _.Usages.Intersect(Partner.Usages).Any())
                .Where(_ => date >= _.StartDate)
                .Where(_ => date <= (_.EndDate ?? DateTime.MaxValue))
                .OrderBy(_ => _.Artist)
                .ThenBy(_ => _.Title);

            var output = filtered.Select(_ => new Data
            {
                Artist = _.Artist,
                Title = _.Title,
                Usages = Partner.Usages,
                StartDate = _.StartDate,
                EndDate = _.EndDate
            });

            return output;
        }
    }
}
