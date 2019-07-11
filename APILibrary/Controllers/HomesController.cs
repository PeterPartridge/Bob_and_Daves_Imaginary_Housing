using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Objects.Interfaces;
using API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APILibrary.Controllers
{
    [Route("api/Property")]
    [ApiController]
    public class HomesController : ControllerBase
    {
        private IFindProperty _findProperty;
        public HomesController(IFindProperty findProperty)
        {
           _findProperty = findProperty;
        }

        [HttpGet (("{id}"),Name ="GetProperty")]
        public ActionResult<IBaseProperty> GetProperty(Guid propertyId)
        {
            if (propertyId == null)
            {
                return BadRequest();
            }
           IBaseProperty baseProperty =  _findProperty.GetBaseProperty(propertyId);
            if (baseProperty == null)
            {
                return BadRequest("Unkown property id");
            }
           return Ok(baseProperty);
        }
        [HttpGet(Name = "GetProperties")]
        public ActionResult<IEnumerable<IBaseProperty>> GetAddresses()
        {
            IEnumerable<IBaseProperty> addresses = _findProperty.GetBaseProperties();
            if (addresses.Count() == 0)
            {
                return BadRequest("Unable to find addresses");
            }
            return Ok(addresses);
        }


    }
}
