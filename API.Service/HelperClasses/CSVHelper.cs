using API.Objects.ConcreteClasses;
using API.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace API.Service.HelperClasses
{
   public static class CSVHelper
    {
        public static IEnumerable<IAddress> MapAddressCSVToObject(string[] addressCSV)
        {
            IList<IAddress> addresses = new List<IAddress>();
            foreach (var csvItem in addressCSV)
            {
                if (csvItem.Equals(addressCSV[0]))
                {
                    continue;
                }
                string[] split = csvItem.Split(",");
                addresses.Add(new Address { AddressId = Guid.Parse(split[0]), PropertyNameOrNumber = split[1], LineOne = split[2], LineTwo = split[3], LineThree = split[4], LineFour = split[5], LineFive = split[6], PostCode = split[7], isCurrentlyUsed = bool.Parse(split[8]) });
            }
            return addresses;
        }
        public static IEnumerable<IBaseProperty> MapPropertyCSVToObject(string[] propertyCSV)
        {
            IList<IBaseProperty> properies = new List<IBaseProperty>();
            foreach (var csvItem in propertyCSV)
            {
                if (csvItem.Equals(propertyCSV[0]))
                {
                    continue;
                }
                string[] split = csvItem.Split(",");
                IEnumerable<Address> addresses = new List<Address>() { new Address { AddressId = Guid.Parse(split[1]) } };
                properies.Add(new BaseProperty { propertyId = Guid.Parse(split[0]), address = addresses, PropertyType = split[2], FreeHolder = split[3] });
            }
            return properies;
        }
        public static string[] ReadCSVFile(string csvToRead)
        {
            try
            {
                return File.ReadAllLines($"{csvToRead}");
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
        }
    }
}
