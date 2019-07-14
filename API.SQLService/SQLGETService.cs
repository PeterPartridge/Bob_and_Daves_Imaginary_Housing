    using API.DataLayer.Interface;
    using API.SharedObjects.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace API.SQLService
    {
        public class SQLGetService : IFindPropertyAsync, IFindAddressAsync
        {
            private IBDIHousingContext _SQLContext;

            public SQLGetService(IBDIHousingContext SQLContext)
            {
                _SQLContext = SQLContext;
            }

            public Task<IAddress> GetAddressAsync(Guid AddressId)
            {
                return Task.Run(() => _SQLContext.AddressDB.FindAsync(AddressId).Result as IAddress);
            }

            public Task<IEnumerable<IAddress>> GetAddressesAsync()
            {
                return Task.Run(() => _SQLContext.AddressDB.ToList() as IEnumerable<IAddress>);
            }

            public Task<IEnumerable<IBaseProperty>> GetBasePropertiesAsync()
            {
                // return _SQLContext.PropertyDB.ToList();
                throw new NotImplementedException();
            }

            public Task<IBaseProperty> GetBasePropertyAsync(Guid propertyId)
            {
                throw new NotImplementedException();
            }
        }
    }
