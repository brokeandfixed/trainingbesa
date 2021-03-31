using PT.TrainningBesa04.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Services
{
    public interface IContactsService
    {
        IEnumerable<ContactDto> GetAll();
        ContactDto GetById(Guid id);
        void Create(ContactDto contactDto);
        void Update(Guid id, ContactDto contactDto);
        void Delete(Guid id);
    }
}
