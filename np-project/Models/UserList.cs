using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace np_project.Models
{
    public class UserList
    {
        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}