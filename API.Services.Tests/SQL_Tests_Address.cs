using API.DataLayer;
using API.DataLayer.ConcreteClass;
using API.DataLayer.Interface;
using API.SharedObjects.Interfaces;
using API.SQLService;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace API.Services.Tests
{
    public class SQL_Tests_Address
    {
        private SQLGetService _SQLService;

        public SQL_Tests_Address()
        {
            var data = new List<Address>
            {
                new Address { AddressId = new Guid("ff44378a-fe47-4526-bf23-6f7217e5f81f") },
                new Address { AddressId = new Guid("3f4e5491-f4e6-477a-a145-a12b990b29f1") },
                new Address { AddressId = new Guid("e3944055-9df7-4ad7-b36a-84bcd00ee1b4") },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Address>>();
            mockSet.As<IQueryable<Address>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Address>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Address>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Address>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
          
            Mock<IBDIHousingContext > mockContext = new Mock<IBDIHousingContext>();
            mockContext.Setup(m => m.AddressDB).Returns(mockSet.Object);
            _SQLService = new SQLGetService(mockContext.Object);
        }

        [Fact]
        public void SQLService_GetAddress_ReturnsASingleAddresses()
        {
            Guid id = new Guid("e3944055-9df7-4ad7-b36a-84bcd00ee1b4");
            IAddress addresses = _SQLService.GetAddressAsync(id).Result;
            Assert.NotNull(addresses);
        }
    }
}
