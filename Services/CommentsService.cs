using System;
using System.Collections.Generic;
using dotnet_blogger.Models;
using dotnet_blogger.Repositories;

namespace dotnet_blogger.Services
{
    public class CommentsService
    {

        private readonly CommentsRepository _repo;
        public CommentsService(CommentsRepository repo)
        {
            _repo = repo;
        }



        public IEnumerable<Comment> Get()
        {
            return _repo.Get();
        }

        public Comment Create(Comment newComment)
        {
            return _repo.Create(newComment);
        }
    }
}