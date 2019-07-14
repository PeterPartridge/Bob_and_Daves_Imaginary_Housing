using API.DataLayer.ConcreteClass;
using API.DataLayer.Interface;
using API.SharedObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DataLayer
{
   public class BDIHousingContext : DbContext,IBDIHousingContext
    {
        public BDIHousingContext(DbContextOptions<BDIHousingContext> options)
            : base(options)
        { }

        public DbSet<Address> AddressDB { get; set; }
        public DbSet<Property> PropertyDB { get; set; }
    }
}
