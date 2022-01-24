using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
    public class DeliveryServices : IDeliveryServices
    {
        private readonly IDeliveryRepository deliveryrepository;
        public DeliveryServices(IDeliveryRepository deliveryrepository)
        {
            this.deliveryrepository = deliveryrepository;
        }
        public bool Delete_Delivary_By_Id(int id)
        {
            return deliveryrepository.Delete_Delivary_By_Id(id);
        }

        public List<Delivery> Get_All_Delivary()
        {
            return deliveryrepository.Get_All_Delivary();
        }

        public List<Delivery> Get_Delivary_Available(int StatusDelivary)
        {
            return deliveryrepository.Get_Delivary_Available(StatusDelivary);
        }

        public Delivery Get_Delivary_By_Id(int id)
        {
            return deliveryrepository.Get_Delivary_By_Id(id);
        }

        public string Insert_Delivary(Delivery delivery)
        {
            return deliveryrepository.Insert_Delivary(delivery);
        }

        public bool Update_Delivary(Delivery delivery)
        {
            return deliveryrepository.Update_Delivary(delivery);
        }
    }
}
