using GameProject;
using GameProject.Concentre;
using GameProject.Entities;

UserManager userManager = new UserManager(new NewEStateUserValidationManager());
User user = new User();

userManager.Add(user);
{
    user.Id = 1;
    user.BirthYear = 2006;
    user.FirstName = "SEMİH";
    user.LastName = "FİLİZ";
    user.IdentityNumber = 3547;
}




Campaign camp = new Campaign();
camp.CampaignName = "Yarı fiyat indirimi";
camp.DiscountRate = 50;

Sales sales = new Sales();
sales.GameName = "Dying Light";
sales.Price = 135;


SaleManager saleManager = new SaleManager(new SaleValidationManager());
saleManager.Sale(user, camp, sales);
