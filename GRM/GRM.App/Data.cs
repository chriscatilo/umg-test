using System;
using System.Collections.Generic;

namespace GRM.App
{
    public class Data
    {
        public string Artist { get; set; }

        public string Title { get; set; }

        public IEnumerable<Usage> Usages { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }

    public enum Usage
    {
        DigitalDownload, Streaming
    }
}
