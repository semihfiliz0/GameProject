using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concentre
{
    internal class SaleManager : ISalesService
    {
        ISaleValidationService _salevalidationService;

        public SaleManager(ISaleValidationService validationService)
        {
            _salevalidationService = validationService;
        }

        public void Sale(User user, Campaign campaign, Sales sales)
        {

            if (_salevalidationService.Validatesale(campaign) == 25)
            {
                sales.Price -= sales.Price * 0.25;
            }
            if (_salevalidationService.Validatesale(campaign) == 50)
            {
                sales.Price -= sales.Price / 2;
            }
            if (_salevalidationService.Validatesale(campaign) == 75)
            {
                sales.Price -= sales.Price * 0.75;
            }

            Console.WriteLine(sales.GameName + " Adlı oyun " + user.FirstName + " adlı kişiye " + campaign.CampaignName + " kampanyasıyla " + sales.Price + " fiyatına satıldı");
        }
    }
}
