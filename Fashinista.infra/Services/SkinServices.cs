using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
    public class SkinServices : ISkinServices
    {
        private readonly ISkinRepository skinrepository;
        public SkinServices(ISkinRepository skinrepository)
        {
            this.skinrepository = skinrepository;
        }
        public bool delete_Skin(int id)
        {
            return skinrepository.delete_Skin(id);
        }

        public List<Skin> getall_Skin()
        {
            return skinrepository.getall_Skin();
        }

        public Skin get_Skin_By_id(int id)
        {
            return skinrepository.get_Skin_By_id(id);
        }

        public string insert_Skin(Skin skin)
        {
            return skinrepository.insert_Skin(skin);
        }

        public bool update_Skin(Skin skin)
        {
            return skinrepository.update_Skin(skin);
        }
    }
}
