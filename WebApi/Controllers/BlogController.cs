using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        IBlogManager _blogManager;

        public BlogController(IBlogManager blogManager)
        {
            _blogManager = blogManager;
        }

        // GET: api/<BlogController>
        [HttpGet]
        public JsonResult Get(int? page)
        {
            page ??= 1;
            JsonResult rs = new(new { });
            rs.Value = new
            {
                page,
                results = _blogManager.GetAllBlogs(page.Value)
            };
            return rs;
        }

        // GET api/<BlogController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            JsonResult rs=new (new{ });
            var blog = _blogManager.GetBlog(id);

            if (blog == null)
            {
                rs.Value = NotFound();
                return rs;
            };
            rs.Value = new
            {
                status = 200,
                results = _blogManager.GetBlog(id)
            };
; 
            return rs;
        }

        // POST api/<BlogController>
        [HttpPost]
        public void Post([FromBody] Blog blg)
        {
            try
            {
                _blogManager.AddBlog(blg);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT api/<BlogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Blog value)
        {
            try
            {
                _blogManager.UpdateBlog(value);

            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/<BlogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _blogManager.RemoveBlog(id);
        }
    }
}
