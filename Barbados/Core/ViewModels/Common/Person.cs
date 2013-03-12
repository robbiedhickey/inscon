using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DALServices.ViewModels.Common
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }

        public string NameLabel { get; set; }
        public string PhoneLabel { get; set; }
        public string EMailLabel { get; set; }
    }
}
