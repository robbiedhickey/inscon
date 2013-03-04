using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class UserNotification
    {
        public int UserNotificationID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DatePosted { get; set; }
        public Nullable<System.DateTime> DateRead { get; set; }
        public virtual User User { get; set; }
    }
}
