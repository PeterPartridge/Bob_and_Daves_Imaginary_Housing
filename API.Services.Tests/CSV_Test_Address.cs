using API.Objects.ConcreteClasses;
using API.Objects.Interfaces;
using API.Service;
using API.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace API.Services.Tests
{
   public class CSV_Test_Address
    {
        private IFindAddress _findAddress;

        public CSV_Test_Address()
        {
            CSVAppSettings cSVApp = new CSVAppSettings();
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
