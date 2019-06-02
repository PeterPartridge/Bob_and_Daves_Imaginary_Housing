using API.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Service.Interfaces
{
   public interface IFindProperty
    {
        IBaseProperty GetBaseProperty(Guid propertyId);
        IAddress GetAddress(Guid AddressId);
        IEnumerable<IBaseProperty> GetBaseProperties();
        IEnumerable<IAddress> GetAddresses();
       
    }
}
