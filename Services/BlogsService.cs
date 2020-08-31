using System;
using System.Collections.Generic;
using dotnet_blogger.Models;
using dotnet_blogger.Repositories;

namespace dotnet_blogger.Services
{
    public class BlogsService
    {

        private readonly BlogsRepository _repo;
        public BlogsService(BlogsRepository repo)
        {
            _repo = repo;
        }



        public IEnumerable<Blog> Get()
        {
            return _repo.Get();
        }

        public Blog Create(Blog newBlog)
        {
            return _repo.Create(newBlog);
        }
    }
}