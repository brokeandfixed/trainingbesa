
using AutoMapper;
using PT.TrainningBesa04.Models.Dtos;
using PT.TrainningBesa04.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Services
{
    public class ContactsService : IContactsService
    {
        private IContactsRepository _repository;
        private IMapper _mapper;

        public ContactsService(IContactsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(ContactDto contactDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactDto> GetAll()
        {
            return _mapper.Map<IEnumerable<ContactDto>>(_repository.GetAll().AsEnumerable());  
        }

        public ContactDto GetById(Guid id)
        {
            Models.Entities.Contact entite = _repository.GetById(id);            
            var dto = _mapper.Map<ContactDto>(entite);

            return dto;
        }

        public void Update(Guid id, ContactDto contactDto)
        {
            throw new NotImplementedException();
        }
    }
}
