using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.Id == 1 && user.BirthYear == 2006 && user.FirstName == "SEMİH" && user.LastName == "FİLİZ" && user.IdentityNumber == 3547)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
