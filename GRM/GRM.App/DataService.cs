using System.Collections.Generic;

namespace GRM.App
{
    public interface IDataService
    {
        IEnumerable<Data> ReadData();
    }

    public class DataService : IDataService
    {
        public IEnumerable<Data> ReadData()
        {
            return new Data[0];
        }
    }
}
