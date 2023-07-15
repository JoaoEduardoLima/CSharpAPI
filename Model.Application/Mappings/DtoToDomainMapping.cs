using AutoMapper;
using Model.Application.DTOs;
using Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Application.Mappings
{
    internal class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping() 
        {
            CreateMap<PersonDTO, Person>();
        }
    }
}
