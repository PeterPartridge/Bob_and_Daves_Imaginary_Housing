using API.Objects.ConcreteClasses;
using API.Objects.Interfaces;
using API.Service.HelperClasses;
using API.Service.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace API.Service
{
    public class CSVService : IFindProperty, IFindAddress
    {
  
        private CSVAppSettings _appSettings;

        public CSVService(CSVAppSettings appSettings)
        {
   
            _appSettings = appSettings;
        }
        public IBaseProperty GetBaseProperty(Guid propertyId)
        {
            IEnumerable<IBaseProperty> mappedPropeties = GetBaseProperties();
            return mappedPropeties.FirstOrDefault(x => x.propertyId.Equals(propertyId));
        }
        public IAddress GetAddress(Guid AddressId)
        {
            IEnumerable<IAddress> mappedAddresses = GetAddresses();
            return mappedAddresses.FirstOrDefault(x => x.AddressId.Equals(AddressId));
        }
        public IEnumerable<IBaseProperty> GetBaseProperties()
        {
            
            string[] propertyCSV = CSVHelper.ReadCSVFile(_appSettings.PropertyCSVFilePath);
            return CSVHelper.MapPropertyCSVToObject(propertyCSV).ToList();
        }
        public IEnumerable<IAddress> GetAddresses()
        {
            string[] addressCSV = CSVHelper.ReadCSVFile(_appSettings.AddressCSVFilePath);
            return CSVHelper.MapAddressCSVToObject(addressCSV);
        }
              
    }
}
