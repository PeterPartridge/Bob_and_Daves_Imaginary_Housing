using API.SharedObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API.SharedObjects.Interfaces
{
    public interface IFindProperty
    {
        IBaseProperty GetBaseProperty(Guid propertyId);

        IEnumerable<IBaseProperty> GetBaseProperties();

    }
    public interface IFindPropertyAsync
    {
        Task<IBaseProperty> GetBasePropertyAsync(Guid propertyId);

        Task<IEnumerable<IBaseProperty>> GetBasePropertiesAsync();

    }
}
