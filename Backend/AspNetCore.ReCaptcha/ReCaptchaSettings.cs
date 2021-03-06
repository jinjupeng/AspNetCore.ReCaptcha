using System;
using System.Diagnostics.CodeAnalysis;

namespace AspNetCore.ReCaptcha
{
    [ExcludeFromCodeCoverage]
    public class ReCaptchaSettings
    {
        public string SiteKey { get; set; }
        public string SecretKey { get; set; }

        public string ContentSecurityPolicy { get; set; }
    }
}
