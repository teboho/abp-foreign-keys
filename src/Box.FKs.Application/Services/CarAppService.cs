using Abp.Application.Services;
using Box.FKs.Services.Dtos;
using Box.FKs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace Box.FKs.Services
{
    public class CarAppService : AsyncCrudAppService<Car, CarDto, long>, ICarAppService
    {
        public CarAppService(IRepository<Car, long> repository) : base(repository)
        {
        }
    }
}
