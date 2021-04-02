using Moq;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using PT.TrainningBesa04.Models.Dtos;
using PT.TrainningBesa04.Services;
using PT.TrainningBesa04.Controllers;
using System.Collections.Generic;
using PT.TrainningBesa04.Models.Entities;

namespace PT.TrainingBesa04.Tests
{    
    public class ContactsControllerTest
    {
        private Mock<IContactsService> _mockIContactsService;
        private ContactsController _contactsController;        
        private Contact _fakeContact;
        private Account _fakeAccount;
        private ContactDto _fakeContactDto;

        void InitData()
        {
            _mockIContactsService = new Mock<IContactsService>();
            _contactsController = new ContactsController(_mockIContactsService.Object);
            
            _fakeAccount = new Account()
            {
                Id = Guid.NewGuid(),
                Name = "Cromisoft",
                Address = "Rue des avenues aux chemins improbables"
            };

            _fakeContact = new Contact()
            {
                Id = Guid.NewGuid(),
                AccountId = _fakeAccount.Id,
                FirstName = "Camilla",
                LastName = "Godspeed",
                Phone = "671 923-3164"
            };            

            _fakeContactDto = GenerateContactDto(_fakeContact, _fakeAccount);
        }

        private ContactDto GenerateContactDto(Contact contact, Account account)
        {
            return new ContactDto()
            {
                Id = contact.Id,
                AccountName = account.Name,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone
            };
        }

        [Fact]
        public void GetByIdContacts_Ok()
        {
            // Arrange
            InitData();
            _mockIContactsService.Setup(_ => _.GetById(It.IsAny<Guid>())).Returns(_fakeContactDto);

            // Act
            var result = _contactsController.GetById(Guid.NewGuid().ToString());

            // Assert
            _mockIContactsService.Verify(_ => _.GetById(It.IsAny<Guid>()), Times.Once);
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
        }

        [Fact]
        public void GetAllContacts_Ok()
        {
            InitData();
            var result = _contactsController.GetAll();

            _mockIContactsService.Verify(_ => _.GetAll(), Times.Once);
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
        }

        [Fact]
        public void CreateContact_Ok()
        {
            InitData();
            _contactsController.Create(_fakeContactDto);
            _mockIContactsService.Verify(_ => _.Create(It.IsAny<ContactDto>()), Times.Once);
        }

        [Fact]
        public void UpdateContact_Ok()
        {
            InitData();
            _contactsController.Update(_fakeContactDto);
            _mockIContactsService.Verify(_ => _.Update(It.IsAny<ContactDto>()), Times.Once);
        }

        [Fact]
        public void DeleteContact_Ok()
        {
            InitData();
            _contactsController.Delete(It.IsAny<Guid>());
            _mockIContactsService.Verify(_ => _.Delete(It.IsAny<Guid>()), Times.Once);
        }        
    }
}
