using Statanly.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Infrastructure.IRepositories
{
    public interface IClickRepository
    {
        Task Add(Click click);
        IEnumerable<Click> Get();
    }
}
