using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DAL.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int TypeID { get; set; }
        public int StatusID { get; set; }

        public virtual IList<Asset> Assets { get; set; }
        public virtual IList<Location> Locations { get; set; } 
    }
}
