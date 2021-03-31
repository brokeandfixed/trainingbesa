using PT.TrainningBesa04.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Repositories
{
    public interface IContactsRepository
    {
        IQueryable<Contact> GetAll();
        Contact GetById(Guid id);
        void Create(Contact contact);
        void Delete(Guid id);
        void SaveChanges();
    }
}
