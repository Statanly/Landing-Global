using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Infrastructure.IRepositories
{
    public interface IUnitOfWork
    {
        bool Save();
        Task<bool> SaveAsync();
    }
}
