using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using dotnet_blogger.Models;

namespace dotnet_blogger.Repositories
{
    public class BlogsRepository
    {
        private readonly IDbConnection _db;

        public BlogsRepository(IDbConnection db)
        {
            _db = db;

        }
        public IEnumerable<Blog> Get()
        {
            string sql = "SELECT * FROM blogs";
            return _db.Query<Blog>(sql);
        }

        public Blog Create(Blog newBlog)
        {
            string sql = @"INSERT INTO blogs
             (title,body,isPublished)
             VALUES
             (@Title, @Body, @isPublished);
             SELECT LAST_INSERT_ID();";
            newBlog.Id = _db.ExecuteScalar<int>(sql, newBlog);
            return newBlog;
        }
    }
}