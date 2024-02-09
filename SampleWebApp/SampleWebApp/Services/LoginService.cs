using SampleWebApp.Interfaces;
using SampleWebApp.Models;

namespace SampleWebApp.Services
{
    public class LoginService:ILoginService
    {
        public LoginResponse Login(LoginRequest request)
        {
            var response = new LoginResponse();
            try
            {
                if (GetLoginDetails()[request.emailAddress] == request.passWord) 
                {
                    return new LoginResponse
                    {
                        loginSuccessful= true,
                        emailAddress= request.emailAddress
                    };
                }
            }
            catch(Exception ex) 
            {

            }
            return response;
        }

        private IDictionary<string, string> GetLoginDetails()
        { 
            return new Dictionary<string, string>() { { "osaks", "123" },{"Abra","2345" } };
        }
    }
}
