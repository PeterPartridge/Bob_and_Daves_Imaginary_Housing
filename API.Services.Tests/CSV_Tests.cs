using API.Objects.ConcreteClasses;
using API.Objects.Interfaces;
using API.Service;
using API.Service.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace API.Services.Tests
{
    public class CSV_Tests
    {
        private IFindProperty _findProperty;
        public CSV_Tests()
        {
            CSVAppSettings cSVApp = new CSVAppSettings();
            _findProperty = new CSVService(cSVApp);
        }
        [Fact]
        public void CSVService_GetBasePropertyUsingGUID_ReturnsASingleProperty()
        {
            IBaseProperty result = _findProperty.GetBaseProperty(Guid.Parse("0788743a-c729-4d1b-9c8f-626ae48a0134"));
            Assert.NotNull(result);
        }
        [Fact]
        public void CSVService_GetBasePropertyUsingInccorectGUID_ReturnANull()
        {         
            IBaseProperty result = _findProperty.GetBaseProperty(Guid.NewGuid());
            Assert.Null(result);
        }
        [Fact]
        public void CSVService_GetBasePropertys_ReturnsAListOfPropertis()
        {
            IEnumerable<IBaseProperty> results = _findProperty.GetBaseProperties();
            Assert.NotEmpty(results);
        }
        [Fact]
        public void CSVService_GetAddresses_ReturnsAListOfAddresses()
        { 
            IEnumerable<IAddress> addresses = _findProperty.GetAddresses();
            Assert.NotEmpty(addresses);
        }
    }
}
