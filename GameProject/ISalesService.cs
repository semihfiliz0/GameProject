using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface ISalesService
    {
        public void Sale(User user,Campaign campaign ,Sales sales);
    }
}
