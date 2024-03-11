using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Box.FKs.Domain;
using Box.FKs.Services;
using Box.FKs.Services.Dtos;

namespace Box.FKs.Services
{
    public interface ICarAppService : IAsyncCrudAppService<CarDto, long>
    {
    }
}
