using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Box.FKs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box.FKs.Services.Dtos
{
    [AutoMap(typeof(Person))]
    public class PersonDto : EntityDto<long>
    {
        // Id is ABP primary key
        public string Name { get; set; }
    }
}
