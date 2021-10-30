using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json.Serialization;

namespace AspNetCore.ReCaptcha
{
    [ExcludeFromCodeCoverage]
    public class ReCaptchaResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("score")]
        public decimal Score { get; set; }
        [JsonPropertyName("action")]
        public string Action { get; set; }
        [JsonPropertyName("challenge_ts")]
        public DateTime ChallengeTimestamp { get; set; }
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }
    }
}
