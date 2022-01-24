using Fashinista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Services
{
   public interface IFroleServices
    {
        public string Insert_Role(Frole role);//from service 
        public bool Delete_Role(int id);
        public bool Update_Role(Frole role);

        public List<Frole> Get_All_Rolle();


        public Frole Get_Rolle_By_Id(int id);
    }
}
