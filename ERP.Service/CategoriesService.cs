using ERP.Data.Models;
using ERP.IRepository.Interfaces;
using ERP.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace ERP.Service
{
    public class CategoriesService : ICategoriesService
    {
        private IRepository<Categories> repository;

        public CategoriesService(IRepository<Categories> repository)
        {
            this.repository = repository;
        }

        public void RemoveCategory(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categories> GetCategories()
        {
            //throw new NotImplementedException();
            return repository.GetAll();
        }

        public Categories GetCategory(long id)
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Categories user)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Categories user)
        {
            throw new NotImplementedException();
        }
    }
}
