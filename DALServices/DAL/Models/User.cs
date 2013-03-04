using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class User
    {
        public User()
        {
            this.UserAreaCoverages = new List<UserAreaCoverage>();
            this.UserContacts = new List<UserContact>();
            this.UserNotifications = new List<UserNotification>();
        }

        public int UserID { get; set; }
        public int OrganizationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int StatusID { get; set; }
        public Nullable<System.Guid> AuthenticationID { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<UserAreaCoverage> UserAreaCoverages { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual ICollection<UserNotification> UserNotifications { get; set; }
    }
}
