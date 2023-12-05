using Statanly.Web.Data;
using Statanly.Web.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Infrastructure.Repositories
{
    public class ClickRepository : IClickRepository
    {
        private ApplicationDbContext context;
        public ClickRepository(IUnitOfWork uof)
        {
            context = uof as ApplicationDbContext;
        }

        public async Task Add(Click click)
        {
            if (click != null)
            {
                context.Clicks.Add(click);
               await this.context.SaveAsync();
            }
        }

        public IEnumerable<Click> Get()
        {
            var results = this.context.Clicks.ToList();
            return results;
        }
      
    }
}
