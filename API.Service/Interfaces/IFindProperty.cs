﻿using API.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Service.Interfaces
{
   public interface IFindProperty
    {
        IBaseProperty GetBaseProperty(Guid propertyId);

        IEnumerable<IBaseProperty> GetBaseProperties();

    }
}
