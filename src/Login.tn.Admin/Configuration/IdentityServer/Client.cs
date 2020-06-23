using System.Collections.Generic;
using Login.tn.Admin.Configuration.Identity;

namespace Login.tn.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}






