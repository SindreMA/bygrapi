using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bygr_test_API.helpers;
using Bygr_test_API.models;
using Microsoft.AspNetCore.Mvc;

namespace Bygr_test_API.Controllers
{
    [Route("api/buyer-info")]
    [ApiController]
    public class buyerInfoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Buyer_Info>> Get()
        {
            var helper = new dataFileHelper();
            return helper.getAllItems();
        }

        [HttpGet("{floor}")]
        public ActionResult<List<Buyer_Info>> Get(int floor)
        {
            var helper = new dataFileHelper();
            return helper.getItemsWithSpesificFloor(floor);
        }

        [HttpPost]
        public void Post(Buyer_Info value)
        {
            var helper = new dataFileHelper();
            helper.addItem(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var helper = new dataFileHelper();
            helper.removeItem(id);
        }
    }
}
