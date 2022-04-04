using Microsoft.AspNetCore.Mvc;
using SbdcImpactPredictor.Interfaces;
using SbdcImpactPredictor.Models.ApiModels;

namespace SbdcImpactPredictor.Controllers
{
    [ApiController]
    [Route("account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody]LoginRequest loginRequest)
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