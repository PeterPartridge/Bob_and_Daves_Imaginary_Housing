using System;
using System.Collections.Generic;
using System.Text;

namespace API.Objects.Interfaces
{
   public interface IAddress
    {
        Guid AddressId { get; set; }
        string PropertyNameOrNumber { get; set; }
        string LineOne { get; set; }
        string LineTwo { get; set; }
        string LineThree { get; set; }
        string LineFour { get; set; }
        string LineFive { get; set; }
        string PostCode { get; set; }
        bool isCurrentlyUsed { get; set; }
        Guid OwnerId { get; set; }
    }
}
