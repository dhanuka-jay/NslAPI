using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NslAPI.Data;

namespace NslAPI.Services.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Member> Members { get; }
        IGenericRepository<Player> Players { get; }
        IGenericRepository<Fees> Fees { get; }
        Task Save();
    }
}
