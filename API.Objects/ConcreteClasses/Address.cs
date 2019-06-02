using API.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Objects.ConcreteClasses
{
    public class Address : IAddress
    {
       
        public Guid AddressId { get; set; }
        public string PropertyNameOrNumber { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string LineFour { get; set; }
        public string LineFive { get; set; }
        public string PostCode { get; set; }
        public bool isCurrentlyUsed { get; set; }
        public Guid OwnerId { get; set; }
    }
}
