using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box.FKs.Domain
{
    public class Car : Entity<long>
    {
        // Id is ABP primary key (automatic)
        public long PersonId { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person PersonModel { get; set; }
    }
}
