using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SbdcImpactPredictor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SbdcImpactPredictor.Controllers
{
    [Route("loans")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly ILoansService _loansService;

        public LoansController(ILoansService loansService)
        {
            _loansService = loansService;
        }

        [HttpGet]
        [Route("{locationName}")]
        public IActionResult GetLoans([FromRoute]string locationName)
        {
            var result = _loansService.GetLoans(locationName);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}