using System.Threading.Tasks;
using LorikeetRESTApp.Core.Models;
using LorikeetRESTApp.Core.Services.Communication;

namespace LorikeetRESTApp.Core.Services
{
    public interface IUserService
    {
         Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
         Task<User> FindByEmailAsync(string email);
    }
}