using Fashinista.core.Data;
using Fashinista.core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashinista.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryServices service;
        public DeliveryController(IDeliveryServices service)
        {
            this.service = service;
        }

        [HttpPost]
        public string Insert_Delivary([FromBody] Delivery delivery)
        {
            return service.Insert_Delivary(delivery);
        }
        [HttpPut]
        public bool Update_Delivary([FromBody] Delivery delivery)
        {
            return service.Update_Delivary(delivery);
        }

        [HttpGet]
        public List<Delivery> Get_All_Delivary()
        {
            return service.Get_All_Delivary();
        }




        [HttpGet("getdeliverybyid/{id}")]
        public Delivery Get_Delivary_By_Id(int id)
        {
            return service.Get_Delivary_By_Id(id);
        }


        [HttpDelete]
        public bool Delete_Delivary_By_Id(int id)
        {
            return service.Delete_Delivary_By_Id(id);
        }
    }
}
