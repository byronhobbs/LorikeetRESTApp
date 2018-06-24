using System.Threading.Tasks;

namespace LorikeetRESTApp.Core.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}