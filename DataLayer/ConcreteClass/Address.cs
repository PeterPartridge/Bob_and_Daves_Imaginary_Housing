using API.SharedObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.DataLayer.ConcreteClass
{
     public class Address : IAddress
    {
        [Key]
        public Guid AddressId { get; set; }
        public string PropertyNameOrNumber { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string LineFour { get; set; }
        public string LineFive { get; set; }
        public string PostCode { get; set; }
        public bool isCurrentlyUsed { get; set; }
        [ForeignKey("Property")]
        public Guid OwnerId { get; set; }
    }
}
