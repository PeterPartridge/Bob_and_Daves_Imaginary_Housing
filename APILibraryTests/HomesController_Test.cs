using API.SharedObjects.ConcreteClasses;
using API.SharedObjects.Interfaces;
using API.Service;
using APILibrary.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace APILibraryTests
{
    public class HomesController_Test
    {
        private IFindProperty _findProperty;
        public HomesController_Test()
        {
            CSVAppSettings cSVApp = new CSVAppSettings();
            string dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            cSVApp.AddressCSVFilePath = $@"{dirPath}\OurAddresses.CSV";
            cSVApp.PropertyCSVFilePath = $@"{dirPath}\OurPropertis.CSV";
            _findProperty = new CSVService(cSVApp);
        }

        [Fact]
        public void HomesController_GetPropertyUsingGuid_ReturnPropertyUsingGuid()
        {
            HomesController homesController = new HomesController(_findProperty);
            var requestType = homesController.GetProperty(Guid.Parse("6905f139-6705-4ed8-87d7-34b5bc3fb0d6"));
            OkObjectResult okRequest = requestType.Result as OkObjectResult;
            IBaseProperty result = (IBaseProperty)okRequest.Value;
            Assert.NotNull(result);
        }
        [Fact]
        public void HomesController_GetPropertyUsingInvalidGuid_ReturnBadRequest()
        {
            HomesController homesController = new HomesController(_findProperty);
            var requestType = homesController.GetProperty(Guid.NewGuid());
            BadRequestObjectResult badRequest = (BadRequestObjectResult) requestType.Result;    
            Assert.True(badRequest.StatusCode == 400);
        }
        [Fact]
        public void HomesController_GetPropertys_WillReturnThreeValues()
        {
            HomesController homesController = new HomesController(_findProperty);
            var requestType = homesController.GetProperties();
            OkObjectResult okRequest = requestType.Result as OkObjectResult;
            IList<IBaseProperty> results = okRequest.Value as IList<IBaseProperty>;
            Assert.True(results.Count() == 3);
        }
    }
}
