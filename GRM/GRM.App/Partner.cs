using System.Collections.Generic;

namespace GRM.App
{
    public class Partner
    {
        public string Name { get; set; }

        public IEnumerable<Usage> Usages { get; set; }
    }
}
