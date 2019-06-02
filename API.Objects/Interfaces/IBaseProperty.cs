using System;
using System.Collections.Generic;
using System.Text;

namespace API.Objects.Interfaces
{
    public interface IBaseProperty
    {
        Guid propertyId { get; set; }
        IEnumerable<IAddress> address { get; set; }
        string PropertyType { get; set; }
        string FreeHolder { get; set; }
    }
}
