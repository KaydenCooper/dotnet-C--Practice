using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_blogger.Services;
using System.Collections.Generic;
using dotnet_blogger.Models;

namespace dotnet_blogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {

        private readonly CommentsService _commentsService;

        public CommentsController(CommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Comment>> Get()
        {
            try
            {
                return Ok(_commentsService.Get());
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }
        [HttpPost]
        public ActionResult<Blog> Create([FromBody] Comment newComment)
        {
            try
            {
                return Ok(_commentsService.Create(newComment));
            }
            catch (System.Exception err)
            {

                return BadRequest(err);
            }
        }
    }
}