// https://www.jsonutils.com/
using System;

namespace CrewNodeLauncher.API.Models
{
    public class Discord
    {
        public string id { get; set; }
        public string uid { get; set; }
        public string discordId { get; set; }
        public string username { get; set; }
        public string discriminator { get; set; }
        public string email { get; set; }
        public bool verifiedEmail { get; set; }
        public string avatar { get; set; }
        public bool inGuild { get; set; }
        public string locale { get; set; }
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class Cn
    {
        public string id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool emailConfirmed { get; set; }
        public string emailToken { get; set; }
        public string ipAddress { get; set; }
        public string sessionHash { get; set; }
        public string provider { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class UserAuth
    {
        public Discord discord { get; set; }
        public Cn cn { get; set; }
        public int _code { get; set; }
    }
}
