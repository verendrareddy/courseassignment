using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registrationrepo.Model
{
    public class RegistrationModel
    {
         public int UserId { get; set; }

        public string Name { get; set; }

        public int EmpId { get; set; }

        public long password { get; set; }

        public string   EmailId { get; set; }   

        public long MobileNo { get; set; }

        public bool Active { get; set; }


    }
}
