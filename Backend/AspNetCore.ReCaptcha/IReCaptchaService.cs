using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.ReCaptcha
{
    public interface IReCaptchaService
    {
        Task<bool> VerifyAsync(string reCaptchaResponse);
    }
}
