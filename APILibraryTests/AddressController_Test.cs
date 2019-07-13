using API.Objects.ConcreteClasses;
using API.Objects.Interfaces;
using API.Service;
using API.Service.Interfaces;
using APILibrary.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;

namespace APILibrary.Test
{
   public class AddressController_Test
    {
        private IFindAddress _findAddress;

        public AddressController_Test()
        {
            CSVAppSettings cSVApp = new CSVAppSettings();
            string dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            cSVApp.AddressCSVFilePath = $@"{dirPath}\OurAddresses.CSV";
            cSVApp.PropertyCSVFilePath = $@"{dirPath}\OurPropertis.CSV";
            _findAddress = new CSVService(cSVApp);
        }

        [Fact]
        public void AddressController_GetAddressUsingGuid_ReturnAddreessFirstLive()
        {
            AddressController addressController = new AddressController(_findAddress);
            var requestType = addressController.GetAddress(Guid.Parse("e3944055-9df7-4ad7-b36a-84bcd00ee1b4"));
            OkObjectResult okRequest = requestType.Result as OkObjectResult;
            IAddress result = (IAddress)okRequest.Value;
            Assert.NotNull(result);
        }
        [Fact]
        public void HomesController_GetPropertyUsingInvalidGuid_ReturnBadRequest()
        {
            AddressController addressController = new AddressController(_findAddress);
            var requestType = addressController.GetAddress(Guid.NewGuid());
            BadRequestObjectResult badRequest = (BadRequestObjectResult)requestType.Result;
            Assert.True(badRequest.StatusCode == 400);
        }
    }
}
