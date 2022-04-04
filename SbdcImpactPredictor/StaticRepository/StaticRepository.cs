using SbdcImpactPredictor.Models.DataModels;
using System.Collections.Generic;

namespace SbdcImpactPredictor.StaticRepository
{
    public class StaticRepository
    {
        public static List<User> users = new List<User>
            {
                new User
                {
                    Address = "HDFC bank",
                    Password = "finastra@123",
                    UserName = "sharukh@test.com",
                    FirstName = "Sharukh",
                    LastName = "Shaji",
                    InstitutionName = "HDFC",
                    PhoneNumber = 1234567890,
                    PinCode = 12345
                },
                new User
                {
                    Address = "ICICI bank",
                    Password = "finastra@123",
                    UserName = "aswin@test.com",
                    FirstName = "Aswin",
                    LastName = "S",
                    InstitutionName = "ICICI",
                    PhoneNumber = 1234567890,
                    PinCode = 12345
                },
                new User
                {
                    Address = "AXIS bank",
                    Password = "finastra@123",
                    UserName = "anisha@test.com",
                    FirstName = "Anisha",
                    LastName = "Raj",
                    InstitutionName = "Axis",
                    PhoneNumber = 1234567890,
                    PinCode = 12345
                }
            };

        public static User FindUser(string username, string password)
        {
            return users.Find(user => user.UserName.ToLower() == username.ToLower() && user.Password.ToLower() == password.ToLower());
        }
    }
}