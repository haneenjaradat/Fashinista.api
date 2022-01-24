using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
   public class FroleServices : IFroleServices
    {
        private readonly IFroleRepository roleRepository;
        public FroleServices(IFroleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        public bool Delete_Role(int id)
        {
            return roleRepository.Delete_Role(id);
        }

        public List<Frole> Get_All_Rolle()
        {
            return roleRepository.Get_All_Rolle();
        }

        public Frole Get_Rolle_By_Id(int id)
        {
            return roleRepository.Get_Rolle_By_Id(id);
        }

        public string Insert_Role(Frole role)
        {
            return roleRepository.Insert_Role(role);
        }

        public bool Update_Role(Frole role)
        {
            return roleRepository.Update_Role(role);
        }
    }
}
