using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogManager
    {
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void RemoveBlog(int? id);
        Blog GetBlog(int? id);
        List<Blog> GetAllBlogs(int page);

    }
}
