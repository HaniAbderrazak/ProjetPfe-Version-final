namespace Login.tn.STS.Identity.Configuration
{
    public class SmtpConfiguration
    {
        public string Host { get; set; } = "smtp.gmail.com";
        public string Login { get; set; } = "haniabderrazak123@gmail.com";
        public string Password { get; set; } = "97539301";
        public int Port { get; set; } = 587; // default smtp port
        public bool UseSSL { get; set; } = true;
    }
}






