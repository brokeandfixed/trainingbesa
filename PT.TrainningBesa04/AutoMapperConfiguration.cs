using AutoMapper;
using PT.TrainningBesa04.Models.Dtos;
using PT.TrainningBesa04.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace PT.TrainningBesa04
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            //TODO [ContactDto doit mapper les deux tables pour éviter le accountName a null]
            /*
             {
                "id": "115d296c-b915-471b-980b-003b539cc5fe",
                "accountName": null,
                "firstName": "Taylor",
                "lastName": "Swift",
                "phone": "557 818-1818"
            },
            {
                "id": "5f628091-143c-466d-9cdb-04971e034976",
                "accountName": null,... 
             */
            CreateMap<ContactDto, Contact>().ReverseMap();
        }
    }
}
