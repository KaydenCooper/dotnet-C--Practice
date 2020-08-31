using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using dotnet_blogger.Models;

namespace dotnet_blogger.Repositories
{
    public class CommentsRepository
    {
        private readonly IDbConnection _db;

        public CommentsRepository(IDbConnection db)
        {
            _db = db;

        }
        public IEnumerable<Comment> Get()
        {
            string sql = "SELECT * FROM comments";
            return _db.Query<Comment>(sql);
        }

        public Comment Create(Comment newComment)
        {
            string sql = @"INSERT INTO comments
             (body,blogId)
             VALUES
             (@Body, @blogId);
             SELECT LAST_INSERT_ID();";
            newComment.Id = _db.ExecuteScalar<int>(sql, newComment);
            return newComment;
        }
    }
}