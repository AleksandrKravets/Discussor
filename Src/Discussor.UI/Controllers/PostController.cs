using Discussor.Core.Application.Posts.Commands.CreatePost;
using Discussor.Core.Application.Posts.Commands.DeletePost;
using Discussor.Core.Application.Posts.Commands.UpdatePost;
using Discussor.Core.Application.Posts.Queries.GetPost;
using Discussor.Core.Application.Posts.Queries.GetPostsList;
using Discussor.Core.Domain.Entities;
using Discussor.WebUI.Infrastructure.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Discussor.WebUI.Controllers
{
    public class PostController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("{themeId}")]
        public async Task<IActionResult> Posts(int themeId)
        {
            var posts = await Mediator.Send(new GetPostsListQuery 
            { 
                ThemeId = themeId,  //удалить параметры в классе запроса
            });

            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Post(int id)
        {
            var post = await Mediator.Send(new GetPostQuery 
            {
                PostId = id,//удалить параметры в классе запроса
            });

            return Ok(post);
        }

        [HttpPost]
        [Authorize]
        [EmailConfirmation]
        public async Task<IActionResult> Create(CreatePostCommand command)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                command.CreatorId = currentUser.Id;
                await Mediator.Send(command);
                return Ok();
            }

            return BadRequest();
        }

        [HttpPut]
        [Authorize]
        [EmailConfirmation]
        public async Task<IActionResult> Edit(UpdatePostCommand command)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(command);
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        [Authorize]
        [EmailConfirmation]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeletePostCommand { PostId = id });
            return NoContent();
        }
    }
}
