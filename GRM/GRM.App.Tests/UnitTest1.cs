using DeepEqual.Syntax;
using System;
using Xunit;


namespace GRM.App.Tests
{
    using static Usage;

    public class UnitTest1
    {
        //Given the supplied above reference data
        //When user enters 'ITunes 1st March 2012'
        //Then the output is:
        //Artist|Title|Usage|StartDate|EndDate
        //Monkey Claw|Black Mountain|digital download|1st Feb 2012|
        //Monkey Claw|Motor Mouth|digital download|1st Mar 2011|
        //Tinie Tempah|Frisky(Live from SoHo)|digital download|1st Feb 2012|
        //Tinie Tempah|Miami 2 Ibiza|digital download|1st Feb 2012|
        [Fact]
        public void Scenario1()
        {
            var dataService = new MockDataService();

            var partnerService = new PartnerService("iTunes", dataService);

            var actual = partnerService.GetAvailableProducts(DateTime.Parse("1 March 2012"));

            var expected = new[]
            {
                new Data
                {
                    Artist = "Monkey Claw",
                    Title = "Iron Horse",
                    Usages = new [] { DigitalDownload, Streaming },
                    StartDate = DateTime.Parse("1 June 2012")
                },
                new Data
                {
                    Artist = "Monkey Claw",
                    Title = "Motor Mouth",
                    Usages = new [] { DigitalDownload, Streaming },
                    StartDate = DateTime.Parse("1 Mar 2011")
                },
                new Data
                {
                    Artist = "Tinie Tempah",
                    Title = "Frisky (Live from SoHo)",
                    Usages = new [] { DigitalDownload, Streaming },
                    StartDate = DateTime.Parse("1 Feb 2012")
                },
                new Data
                {
                    Artist = "Tinie Tempah",
                    Title = "Miami 2 Ibiza",
                    Usages = new [] { DigitalDownload },
                    StartDate = DateTime.Parse("1 Feb 2012")
                }
            };

            
            actual.ShouldDeepEqual(expected);
        }
    }
}
