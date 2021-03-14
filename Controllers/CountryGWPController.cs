using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Galytix.WebApi.Service;
using Galytix.WebApi.Helpers;
using System.Collections.Generic;
using Galytix.WebApi.Models;

namespace Galytix.WebApi.Controllers
{
    [ApiController]
    [Route("/api/gwp")]
    public class CountryGWPController : ControllerBase
    {
        private readonly GWPService gWPService;

        public CountryGWPController(GWPService gWPService)
        {
            this.gWPService = gWPService;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("avg")]
        public async Task<IActionResult> GetAvg([FromBody] Input input)
        {
            if (input.country == null || input.linesOfBusiness == null)
            {
                return BadRequest("Please enter a valid model");
            }
            if (input.linesOfBusiness.Count == 0)
            {
                return BadRequest("Please enter a line of business");
            }
            try
            {
                var data = await gWPService.GetData(input);
                return Ok(data);
            }
            catch
            {
                return BadRequest("An error occured");
            }
        }
    }
}