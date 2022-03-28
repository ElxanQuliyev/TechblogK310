using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _dal;

        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public void AddCategory(Category entity)
        {
            _dal.Add(entity);
        }

        public List<Category> GetAllCategories()
        {
            return _dal.GetAll();
        }

        public Category GetCategory(int? id)
        {
            return _dal.Get(c=>c.Id == id);    
        }

        public void RemoveCategory(int? id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category entity)
        {
            _dal.Update(entity);
        }
    }
}
