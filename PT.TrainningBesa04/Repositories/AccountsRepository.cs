using PT.TrainningBesa04.Models;
using PT.TrainningBesa04.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Repositories
{
    public class AccountsRepository : IAccountsRepository
    {
        private RDL00001TrainingBesa04Context _context;

        public AccountsRepository(RDL00001TrainingBesa04Context context) 
        {
            _context = context;
        }

        public void Create(Account account)
        {
            _context.Accounts.Add(account);
        }

        public void Delete(Guid id)
        {
            var account = GetById(id);
            _context.Accounts.Remove(account);
        }

        public IQueryable<Account> GetAll()
        {
            return _context.Accounts.AsQueryable();
        }

        public Account GetById(Guid id)
        {
            return _context.Accounts.FirstOrDefault(_ => _.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
