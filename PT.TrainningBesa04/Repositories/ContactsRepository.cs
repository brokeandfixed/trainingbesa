using PT.TrainningBesa04.Models;
using PT.TrainningBesa04.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Repositories
{
    public class ContactsRepository : IContactsRepository
    {
        private RDL00001TrainingBesa04Context _context; 

        public ContactsRepository(RDL00001TrainingBesa04Context context) 
        {
            _context = context;
        }

        public void Create(Contact contact)
        {
            _context.Contacts.Add(contact);
        }

        public void Delete(Guid id)
        {
            var contact = GetById(id);
            _context.Contacts.Remove(contact);
        }

        public IQueryable<Contact> GetAll()
        {
            return _context.Contacts.AsQueryable();
        }

        public Contact GetById(Guid id)
        {
            var contact = GetById(id);
            return _context.Contacts.FirstOrDefault(_ => _.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
