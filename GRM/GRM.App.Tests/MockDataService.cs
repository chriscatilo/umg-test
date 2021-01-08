using System;
using System.Collections.Generic;

namespace GRM.App.Tests
{
    using static Usage;

    public class MockDataService : IDataService
    {

        public IEnumerable<Data> ReadData() 
        {
            var source = new[]
            {
                new Data
                {
                    Artist = "Tinie Tempah",
                    Title = "Frisky (Live from SoHo)",
                    Usages = new [] { DigitalDownload, Streaming },
                    StartDate = DateTime.Parse("1st Feb 2012")
                },
                new Data
                {
                    Artist = "Tinie Tempah",
                    Title = "Miami 2 Ibiza",
                    Usages = new [] { DigitalDownload },
                    StartDate = DateTime.Parse("1st Feb 2012")
                },
                new Data
                {
                    Artist = "Tinie Tempah",
                    Title = "Till I'm Gone",
                    Usages = new [] { DigitalDownload },
                    StartDate = DateTime.Parse("1st Aug 2012")
                },
                new Data
                {
                    Artist = "Monkey Claw",
                    Title = "Black Mountain",
                    Usages = new [] { DigitalDownload },
                    StartDate = DateTime.Parse("1st Feb 2012")
                },
                new Data
                {
                    Artist = "Monkey Claw",
                    Title = "Iron Horse",
                    Usages = new [] { DigitalDownload, Streaming },
                    StartDate = DateTime.Parse("1st June 2012")
                },
                new Data
                {
                    Artist = "Monkey Claw",
                    Title = "Motor Mouth",
                    Usages = new [] { DigitalDownload, Streaming },
                    StartDate = DateTime.Parse("1st Mar 2011")
                },
                new Data
                {
                    Artist = "Monkey Claw",
                    Title = "Christmas Special",
                    Usages = new [] { Streaming },
                    StartDate = DateTime.Parse("25st Dec 2012"),
                    EndDate = DateTime.Parse("31st Dec 2012")
                }
            };

            return source;
        }
    }
}
