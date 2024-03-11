using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Box.FKs.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box.FKs.Services.Dtos
{
    [AutoMap(typeof(Car))]
    public class CarDto : EntityDto<long>
    {
        // Id is ABP primary key (automatic)
        public long PersonId { get; set; }
        public string Name { get; set; }

        //[ForeignKey(nameof(PersonId))]
        //public Person PersonModel { get; set; }
    }
}
