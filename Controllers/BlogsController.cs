using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_blogger.Services;
using System.Collections.Generic;
using dotnet_blogger.Models;

namespace dotnet_blogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {

        private readonly BlogsService _blogsService;
        private readonly CommentsService _commentsService;

        public BlogsController(BlogsService blogsService, CommentsService commentsService)
        {
            _blogsService = blogsService;
            _commentsService = commentsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            try
            {
                return Ok(_blogsService.Get());
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }
        [HttpPost]
        public ActionResult<Blog> Create([FromBody] Blog newBlog)
        {
            try
            {
                return Ok(_blogsService.Create(newBlog));
            }
            catch (System.Exception err)
            {

                return BadRequest(err);
            }
        }
    }
}