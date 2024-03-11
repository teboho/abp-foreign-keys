using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box.FKs.Domain
{
    public class Person : Entity<long>
    {
        // Id is ABP primary key
        public string Name { get; set; }

    }
}
