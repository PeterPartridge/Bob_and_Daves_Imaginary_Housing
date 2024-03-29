using API.SharedObjects.ConcreteClasses;
using API.SharedObjects.Interfaces;
using API.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xunit;

namespace API.Services.Tests
{
    public class CSV_Tests_Property
    {
        private IFindProperty _findProperty;
        public CSV_Tests_Property()
        {
            CSVAppSettings cSVApp = new CSVAppSettings();
            string dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            cSVApp.AddressCSVFilePath = $@"{dirPath}\OurAddresses.CSV";
            cSVApp.PropertyCSVFilePath = $@"{dirPath}\OurPropertis.CSV";
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

    }
}
