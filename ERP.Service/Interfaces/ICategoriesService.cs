using ERP.Data.Models;
using System.Collections.Generic;

namespace ERP.Service.Interfaces
{
    public interface ICategoriesService
    {
        IEnumerable<Categories> GetCategories();
        Categories GetCategory(long id);
        void AddCategory(Categories user);
        void UpdateCategory(Categories user);
        void RemoveCategory(long id);
    }
}
