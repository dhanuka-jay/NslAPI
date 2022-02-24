using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NslAPI.Data;
using NslAPI.Services.IRepository;

namespace NslAPI.Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Member> _members;
        private IGenericRepository<Player> _players;
        private IGenericRepository<Fees> _fees;


        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        //*** If _members is null return new instance ***//
        public IGenericRepository<Member> Members => _members ??= new GenericRepository<Member>(_context);
        public IGenericRepository<Player> Players => _players ??= new GenericRepository<Player>(_context);
        public IGenericRepository<Fees> Fees => _fees ??= new GenericRepository<Fees>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
