using System.Collections.Generic;

namespace GRM.App
{
    public interface IDataService
    {
        IEnumerable<Data> ReadData();

        IEnumerable<Partner> GetPartners();
    }

    public class DataService : IDataService
    {
        public IEnumerable<Partner> GetPartners() => new[]
        {
            new Partner
            {
                Name = "iTunes",
                Usages = new[] { Usage.DigitalDownload }
            },
            new Partner
            {
                Name = "YouTube",
                Usages = new[] { Usage.Streaming }
            }

        };
        
        public IEnumerable<Data> ReadData()
        {
            return new Data[0];
        }
    }
}
