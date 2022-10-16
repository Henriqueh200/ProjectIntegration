using System.Threading.Tasks;

namespace ProjectIntegration.Services
{
    public interface ILoginService
    {
        public  Task<string> Login();
    }
}
