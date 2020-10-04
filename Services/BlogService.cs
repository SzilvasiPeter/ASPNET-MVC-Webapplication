using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class BlogService : IBlogService
    {
        private List<Blog> myBlogs;

        public BlogService()
        {
            myBlogs = new List<Blog>();
        }

        public List<Blog> GetAllBlogs()
        {
            return myBlogs;
        }

        public Blog AddBlog(Blog blogItem)
        {
            myBlogs.Add(blogItem);
            return blogItem;
        }

        public Blog UpdateBlog(int blogId, Blog blogItem)
        {
            for (int i = 0; i < myBlogs.Count; i++)
            {
                if (myBlogs[i].Id == blogId)
                {
                    myBlogs[i] = blogItem;
                }
            }

            return blogItem;
        }

        public int DeleteBlog(int blogId)
        {
            for (int i = 0; i < myBlogs.Count; i++)
            {
                if (myBlogs[i].Id == blogId)
                {
                    myBlogs.RemoveAt(i);
                }
            }

            return blogId;
        }
    }
}