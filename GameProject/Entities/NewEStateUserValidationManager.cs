using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;

namespace GameProject.Entities
{
    internal class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            return true;
        }
    }
}
