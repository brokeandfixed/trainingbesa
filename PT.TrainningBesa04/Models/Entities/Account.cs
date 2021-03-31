using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Models.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
