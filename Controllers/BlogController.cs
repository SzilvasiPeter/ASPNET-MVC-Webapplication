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
        public ActionResult<List<Blog>> GetProducts()
        {
            return myService.GetAllBlogs();
        }

        [HttpPost("/api/blogs")]
        public ActionResult<Blog> AddProduct(Blog blog)
        {
            myService.AddBlog(blog);
            return blog;
        }

        [HttpPut("/api/blogs/{id}")]
        public ActionResult<Blog> UpdateProduct(int id, Blog blog)
        {
            myService.UpdateBlog(id, blog);
            return blog;
        }

        [HttpDelete("/api/blogs/{id}")]
        public ActionResult<int> DeleteProduct(int id)
        {
            myService.DeleteBlog(id);
            return id;
        }
    }
}