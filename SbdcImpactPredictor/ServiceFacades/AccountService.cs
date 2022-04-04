using SbdcImpactPredictor.Interfaces;
using SbdcImpactPredictor.Models.DataModels;

namespace SbdcImpactPredictor.ServiceFacades
{
    public class AccountService : IAccountService
    {
        public User FindUser(string username, string password) => StaticRepository.StaticRepository.FindUser(username, password);
    }
}