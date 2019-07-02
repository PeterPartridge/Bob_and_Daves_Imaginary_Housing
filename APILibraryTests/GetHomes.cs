using API.Objects.ConcreteClasses;
using API.Objects.Interfaces;
using API.Service;
using API.Service.Interfaces;
using APILibrary.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace APILibraryTests
{
    public class GetHomes
    {
        private IFindProperty _findProperty;
        public GetHomes()
        {
            CSVAppSettings cSVApp = new CSVAppSettings();
            _findProperty = new CSVService(cSVApp );
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
            BadRequestResult badRequest = requestType.Result as BadRequestResult;    
            Assert.NotNull(badRequest);
        }
    }
}
