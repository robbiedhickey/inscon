using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DAL.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int TypeID { get; set; }

        public int OrganizationID { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
