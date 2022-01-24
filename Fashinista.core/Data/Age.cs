using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Data
{

    public class Age
    {
        public decimal Id { get; set; }
        public string AGE_PERIOD { get; set; }
        public decimal START_AGE { get; set; }
        public decimal END_AGE { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
