using registrationrepo.Abstract;
using registrationrepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static registrationrepo.Repository.regRepo;

namespace registrationrepo.Repository
{
    public class regRepo : IAdd
    {

        private readonly regContext _context;

        public regRepo(regContext context)
        {
            _context = context;
        }

        public void Add(RegistrationModel reguser)
        {
            _context.Users.Add(reguser);
            _context.SaveChanges();
        }

        // Implement other methods as before...
    }
}
