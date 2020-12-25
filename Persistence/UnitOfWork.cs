using System.Threading.Tasks;

namespace Product.Web.Api.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductDbContext Context;
        public UnitOfWork(ProductDbContext Context)
        {
            this.Context = Context;
        }
        public async Task Complete()
        {
            await Context.SaveChangesAsync();
        }
    }
}