using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class SaleValidationManager : ISaleValidationService
    {
        public int Validatesale(Campaign campaign)
        {
            if (campaign.DiscountRate == 75)
            {
                return 75;
            }
            if (campaign.DiscountRate == 50)
            {
                return 50;
            }
            if (campaign.DiscountRate == 25)
            {
                return 25;
            }
            else { return 0; }
        }
    }
}
