using API.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Service.Interfaces
{
    public interface IFindAddress
    {
        IAddress GetAddress(Guid AddressId);
        IEnumerable<IAddress> GetAddresses();

    }
}
