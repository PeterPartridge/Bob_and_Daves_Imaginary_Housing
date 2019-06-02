using API.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Objects.AbstractClasses
{
    public abstract class AbstractBaseProperty : IBaseProperty
    {
     
        public Guid propertyId { get; set; }
        public IEnumerable<IAddress> address { get; set; }
        public string PropertyType { get; set; }
        public string FreeHolder { get; set; }
    }
}
