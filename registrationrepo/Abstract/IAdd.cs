using registrationrepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registrationrepo.Abstract
{
    public interface IAdd
    {
      
            void Add(RegistrationModel reguser);
           
            // Add other methods as needed (update, delete)
        }
    }
}
