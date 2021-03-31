using Microsoft.EntityFrameworkCore;
using PT.TrainningBesa04.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Models
{
    public class RDL00001TrainingBesa04Context : DbContext
    {        
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public RDL00001TrainingBesa04Context(DbContextOptions options) : base(options)
        {
            
        }
    }
}
