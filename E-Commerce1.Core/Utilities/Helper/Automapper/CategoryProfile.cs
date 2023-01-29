using AutoMapper;
using E_Commerce1.Entities.Concrete;
using E_Commerce1.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Core.Utilities.Helper.Automapper
{
    public class CategoryProfile : Profile
    {

        public CategoryProfile()
        {
            CreateMap<CategoryDTO, Category>();
        




        }
    }
}
