using System.Threading.Tasks;

namespace Product.Web.Api.Persistence
{
    public interface IUnitOfWork
    {
         Task Complete();
    }
}