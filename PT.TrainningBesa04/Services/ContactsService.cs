
using AutoMapper;
using PT.TrainningBesa04.Models.Dtos;
using PT.TrainningBesa04.Models.Entities;
using PT.TrainningBesa04.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

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
            _contactRepo.Create(GenerateContact(contactDto));
        }

        private Contact GenerateContact(ContactDto contactDto)
        {
            Guid accountGuid = _accountRepo.GetByName(contactDto.AccountName).Id;

            Contact contact = new Contact();
            contact.AccountId = accountGuid;
            contact.FirstName = contactDto.FirstName;
            contact.LastName = contactDto.LastName;
            contact.Phone = contactDto.Phone;

            return contact;
        }

        public void Delete(Guid id)
        {            
            _contactRepo.Delete(id);
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
            Contact entite = _contactRepo.GetById(id);            
            var dto = _mapper.Map<ContactDto>(entite);

            return dto;
        }

        public void Update(ContactDto contactDto)
        {
            Contact contact = GenerateContact(contactDto);
            contact.Id = contactDto.Id;
            _contactRepo.Update(contact);
        }

        public string GetAccountNameById(Guid id)
        {
            var accountEntity = _accountRepo.GetById(id);
            return accountEntity.Name;
        }
    }
}
