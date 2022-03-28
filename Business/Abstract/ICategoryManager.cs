using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        void AddCategory(Category entity);
        void UpdateCategory(Category entity);
        void RemoveCategory(int? id);
        Category GetCategory(int? id);
        List<Category> GetAllCategories();

    }
}
