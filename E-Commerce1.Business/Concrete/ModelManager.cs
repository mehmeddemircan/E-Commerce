using E_Commerce1.Business.Abstract;
using E_Commerce1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.Business.Concrete
{
    public class ModelManager : IModelService
    {
        public Task<List<Model>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Model> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model>> GetList(Expression<Func<Model, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Model> GetSingle(Expression<Func<Model, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Model> TAdd(Model entity)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Model entity)
        {
            throw new NotImplementedException();
        }
    }
}
