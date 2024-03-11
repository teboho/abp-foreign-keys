using Abp.Application.Services;
using Box.FKs.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box.FKs.Services
{
    public interface IPersonAppService : IAsyncCrudAppService<PersonDto, long>
    {
    }
}
