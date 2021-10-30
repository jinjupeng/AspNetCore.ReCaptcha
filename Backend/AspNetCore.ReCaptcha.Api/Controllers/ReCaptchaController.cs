using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.ReCaptcha.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReCaptchaController : ControllerBase
    {
        private readonly IReCaptchaService _reCaptchaService;

        public ReCaptchaController(IReCaptchaService reCaptchaService)
        {
            _reCaptchaService = reCaptchaService;
        }

        [HttpGet]
        [Route("login")]
        public async Task<IActionResult> ReCaptchaValidate(string token)
        {
            var result = await _reCaptchaService.VerifyAsync(token);
            return Ok(result);
        }
    }
}
