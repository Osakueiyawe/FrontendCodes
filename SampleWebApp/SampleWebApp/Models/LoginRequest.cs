namespace SampleWebApp.Models
{
    public class LoginRequest
    {
        public string emailAddress { get; set; }
        public string passWord { get; set; }
        public bool rememberMe { get; set; }
    }
}
