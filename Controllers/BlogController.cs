using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private IBlogService myService;

        public BlogController(IBlogService myService)
        {
            this.myService = myService;
        }

        [HttpGet("/api/blogs")]
        public ActionResult<List<Blog>> GetBlogs()
        {
            return myService.GetAllBlogs();
        }

        [HttpPost("/api/blogs")]
        public ActionResult<Blog> AddBlog(Blog blog)
        {
            myService.AddBlog(blog);
            return blog;
        }

        [HttpPut("/api/blogs/{id}")]
        public ActionResult<Blog> UpdateBlog(int id, Blog blog)
        {
            myService.UpdateBlog(id, blog);
            return blog;
        }

        [HttpDelete("/api/blogs/{id}")]
        public ActionResult<int> DeleteBlog(int id)
        {
            myService.DeleteBlog(id);
            return id;
        }
    }
}