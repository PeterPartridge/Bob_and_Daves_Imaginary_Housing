using API.SharedObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.DataLayer.ConcreteClass
{
   public class Property 
    {
        [Key]
       public Guid propertyId { get; set; }    
       public string PropertyType { get; set; }
       public string FreeHolder { get; set; }
       [ForeignKey("OwnerId")]
       public IEnumerable<Address> address { get; set; }
        
    }
}
