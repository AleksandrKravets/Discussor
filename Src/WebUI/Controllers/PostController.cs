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
using Discussor.WebUI.Infrastructure.Pagination;

//
namespace Discussor.WebUI.Controllers
{
    public class PostController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Posts(int themeId, int pageNumber = 1, int pageSize = 7)
        {
            var posts = await Mediator.Send(new GetPostsListQuery 
            { 
                ThemeId = themeId, 
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            ViewData["PagingInfo"] = new PagingInfo
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = posts.NumberOfAllPosts
            };

            return View(posts);
        }

        [HttpGet]
        public async Task<IActionResult> Post(int postId, int pageNumber = 1, int pageSize = 7)
        {
            var post = await Mediator.Send(new GetPostQuery 
            {
                PostId = postId,
                PageSize = pageSize,
                PageNumber = pageNumber
            });

            ViewData["PagingInfo"] = new PagingInfo
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = post.NumberOfAllReplies
            };

            return View(post);
        }

        [HttpGet]
        [Authorize]
        [EmailConfirmation]
        public IActionResult Create(int themeId)
        {
            return View(new CreatePostCommand { ThemeId = themeId });
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
                return RedirectToAction("Posts", new { themeId = command.ThemeId });
            }

            ModelState.AddModelError("", "The entered data is incorrect");
            return View(command);
        }

        [HttpGet]
        [Authorize]
        [EmailConfirmation]
        public async Task<IActionResult> Edit(int postId)
        {
            var post = await Mediator.Send(new GetPostQuery { PostId = postId });

            return View(new UpdatePostCommand
            {
                PostId = postId,
                Content = post.Content,
                Title = post.Title,
                ThemeId = post.ThemeId
            });
        }

        [HttpPost]
        [Authorize]
        [EmailConfirmation]
        public async Task<IActionResult> Edit(UpdatePostCommand command)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(command);
                return RedirectToAction("Posts", "Post", new { command.ThemeId });
            }

            ModelState.AddModelError("", "The entered data is incorrect");
            return View(command);
        }

        [Authorize]
        [EmailConfirmation]
        public async Task<IActionResult> Delete(int postId, int themeId)
        {
            await Mediator.Send(new DeletePostCommand { PostId = postId });
            return RedirectToAction("Posts", "Post", new { themeId });
        }
    }
}
