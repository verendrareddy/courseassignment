using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registrationrepo.Model
{
    public class regContext : DbContext
    {
        public regContext() : base(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString) { }

        public DbSet<RegistrationModel> Users { get; set; }
    }
}
