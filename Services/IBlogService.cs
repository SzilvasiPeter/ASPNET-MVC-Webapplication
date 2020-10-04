using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Services
{
    public interface IBlogService
    {
        List<Blog> GetAllBlogs();
        
        Blog AddBlog(Blog blogItem);
        
        Blog UpdateBlog(int blogId, Blog blogItem);
        
        int DeleteBlog(int blogId);
    }
}