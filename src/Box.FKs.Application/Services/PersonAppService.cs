using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Box.FKs.Domain;
using Box.FKs.Services.Dtos;
using Abp.Domain.Repositories;

namespace Box.FKs.Services
{
    public class PersonAppService : AsyncCrudAppService<Person, PersonDto, long>, IPersonAppService
    {
        public PersonAppService(IRepository<Person, long> repository) : base(repository)
        {
        }
    }
}
