using PT.TrainningBesa04.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Repositories
{
    public interface IAccountsRepository
    {
        IQueryable<Account> GetAll();
        Account GetById(Guid id);
        void Create(Account account);
        void Delete(Guid id);
        void SaveChanges();
    }
}
