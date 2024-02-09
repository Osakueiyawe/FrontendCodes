using SampleWebApp.Models;

namespace SampleWebApp.Interfaces
{
    public interface ILoginService
    {
        public LoginResponse Login(LoginRequest request);
    }
}
