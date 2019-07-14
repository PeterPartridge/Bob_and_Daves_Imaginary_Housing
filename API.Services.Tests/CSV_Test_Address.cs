using API.SharedObjects.ConcreteClasses;
using API.SharedObjects.Interfaces;
using API.Service;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xunit;

namespace API.Services.Tests
{
   public class CSV_Test_Address
    {
        private IFindAddress _findAddress;

        public CSV_Test_Address()
        {
            CSVAppSettings cSVApp = new CSVAppSettings();
            string dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            cSVApp.AddressCSVFilePath = $@"{dirPath}\OurAddresses.CSV";
               _findAddress = new CSVService(cSVApp);
        }

        [Fact]
        public void CSVService_GetAddresses_ReturnsAListOfAddresses()
        {
            IEnumerable<IAddress> addresses = _findAddress.GetAddresses();
            Assert.NotEmpty(addresses);
        }
    }
}
