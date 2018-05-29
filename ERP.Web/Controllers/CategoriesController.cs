using ERP.Data.Models;
using ERP.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ERP.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService service;

        public CategoriesController(ICategoriesService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Categories> Get()
        {
            try
            {
                return service.GetCategories();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public Categories Get(int id)
        {
            try
            {
                return service.GetCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public Categories Post([FromBody] Categories _customer)
        {
            try
            {
                service.AddCategory(_customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _customer;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                Categories category = service.GetCategory(id);
                service.RemoveCategory(category.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		
    }
}