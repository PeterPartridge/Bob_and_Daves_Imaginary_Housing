using API.SharedObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API.SharedObjects.Interfaces
{
    public interface IFindAddress
    {
        IAddress GetAddress(Guid AddressId);
        IEnumerable<IAddress> GetAddresses();

    }
    public interface IFindAddressAsync
    {
        Task<IAddress> GetAddressAsync(Guid AddressId);
        Task<IEnumerable<IAddress>> GetAddressesAsync();

    }
}
