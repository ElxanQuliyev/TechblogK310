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
    public class BlogManager : IBlogManager
    {
        IBlogDal _dal;
        public BlogManager(IBlogDal dal)
        {
            _dal = dal;
        }

        public void AddBlog(Blog blog)
        {
            _dal.Add(blog);
        }

        public List<Blog> GetAllBlogs(int page)
        {
            var skipCount=(page - 1)*3;
            return _dal.GetAll(c=>!c.IsDeleted).Skip(skipCount).Take(3).ToList();
        }

        public Blog GetBlog(int? id)
        {
           return _dal.Get(c=>c.Id==id && !c.IsDeleted);
        }

        public void RemoveBlog(int? id)
        {
           var blog= _dal.Get(c => c.Id == id);
            blog.IsDeleted = true;
            _dal.Update(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            _dal.Update(blog);
        }
    }
}
