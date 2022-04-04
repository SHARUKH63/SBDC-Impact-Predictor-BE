using SbdcImpactPredictor.Interfaces;
using SbdcImpactPredictor.Models.ApiModels;
using System.Web.Http;

namespace SbdcImpactPredictor.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public IHttpActionResult Login(LoginRequest loginRequest)
        {
            var result = _accountService.FindUser(loginRequest.UserName, loginRequest.Password);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}