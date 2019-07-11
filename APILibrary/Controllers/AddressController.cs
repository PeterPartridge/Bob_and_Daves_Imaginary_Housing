﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Objects.Interfaces;
using API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APILibrary.Controllers
{
    public class AddressController : Controller
    {
        private IFindAddress _findAddress;

        public AddressController(IFindAddress findAddress)
        {
            _findAddress = findAddress;
        }
        [HttpGet(Name = "GetAddresses")]
        public ActionResult<IEnumerable<IAddress>> GetAddresses()
        {
            IEnumerable<IAddress> addresses = _findAddress.GetAddresses();
            if (addresses.Count() == 0)
            {
                return BadRequest("Unable to find addresses");
            }
            return Ok(addresses);
        }
        [HttpGet(Name ="FindAddresses")]
        public ActionResult<IAddress> GetAddress(Guid addressId)
        {
           
            if (addressId == null)
            {
                return BadRequest();
            }
            IAddress address = _findAddress.GetAddress(addressId);
            if (address == null)
            {
                return BadRequest("Unkown address id");
            }
            return Ok(address);
        }
    }
}