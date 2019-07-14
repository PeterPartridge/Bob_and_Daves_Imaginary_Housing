using API.DataLayer.ConcreteClass;
using API.SharedObjects.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.DataLayer.Interface
{
    public interface IBDIHousingContext
    {
        DbSet<Address> AddressDB { get; set; }
        DbSet<Property> PropertyDB { get; set; }
    }
}
