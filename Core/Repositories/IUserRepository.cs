using System.Threading.Tasks;
using LorikeetRESTApp.Core.Models;

namespace LorikeetRESTApp.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}