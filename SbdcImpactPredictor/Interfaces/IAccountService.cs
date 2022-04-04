using SbdcImpactPredictor.Models.DataModels;

namespace SbdcImpactPredictor.Interfaces
{
    public interface IAccountService
    {
        User FindUser(string username, string password);
    }
}