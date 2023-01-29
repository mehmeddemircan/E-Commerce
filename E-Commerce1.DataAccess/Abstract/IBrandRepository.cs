using E_Commerce1.Core.DataAccess;
using E_Commerce1.Entities.Concrete;
using E_Commerce1.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.DataAccess.Abstract
{
    public interface IBrandRepository : IEntityRepository<Brand>
    {

        public Task<BrandDTO> GetOneBrandDetail(int id);
    }
}
