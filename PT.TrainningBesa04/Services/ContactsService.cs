
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
        private IContactsRepository _contactRepo;
        private IAccountsRepository _accountRepo;
        private IMapper _mapper;

        public ContactsService(IContactsRepository contactRepo, IMapper mapper, IAccountsRepository accountRepo)
        {
            _contactRepo = contactRepo;
            _accountRepo = accountRepo;
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
            var contactEntities = _contactRepo.GetAll().AsEnumerable();
            var contactDtos = contactEntities.Select(contactEntity =>
            {
                var contactDto = _mapper.Map<ContactDto>(contactEntity);
                contactDto.AccountName = GetAccountNameById(contactEntity.AccountId);
                return contactDto;
            });

            return contactDtos;
        }

        public ContactDto GetById(Guid id)
        {
            Models.Entities.Contact entite = _contactRepo.GetById(id);            
            var dto = _mapper.Map<ContactDto>(entite);

            return dto;
        }

        public void Update(Guid id, ContactDto contactDto)
        {
            throw new NotImplementedException();
        }

        public string GetAccountNameById(Guid id)
        {
            var accountEntity = _accountRepo.GetById(id);
            return accountEntity.Name;
        }
    }
}
