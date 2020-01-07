//using Application.Posts.Commands.CreatePost;
//using Application.Posts.Commands.DeletePost;
//using Application.Posts.Commands.UpdatePost;
//using Application.Posts.Queries.GetPost;
//using Application.Posts.Queries.GetPostsList;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;

//namespace WebUI.Controllers
//{
//    public class PostController : BaseController
//    {
//        [HttpGet]
//        public async Task<IActionResult> Posts(int themeId)
//        {
//            var posts = await Mediator.Send(new GetPostsListQuery { ThemeId = themeId });
//            return View(posts);
//        }

//        [HttpGet]
//        public async Task<IActionResult> Post(int postId)
//        {
//            var post = await Mediator.Send(new GetPostQuery { PostId = postId });
//            return View(post);
//        }

//        [HttpGet]
//        public IActionResult Create(int themeId)
//        {
//            return View(new CreatePostCommand { ThemeId = themeId } );
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create(CreatePostCommand command)
//        {
//            if (ModelState.IsValid)
//            {
//                await Mediator.Send(command);
//                return RedirectToAction("Posts", new { themeId = command.ThemeId });
//            }

//            ModelState.AddModelError("", "The entered data is incorrect");
//            return View(command);
//        }

//        [HttpGet]
//        [Authorize]
//        public async Task<IActionResult> Edit(int postId)
//        {
//            var post = await Mediator.Send(new GetPostQuery { PostId = postId });

//            return View(new UpdatePostCommand 
//            { 
//                PostId = postId,
//                Content = post.Content,
//                Title = post.Title
//            });
//        }

//        [HttpPost]
//        [Authorize]
//        public async Task<IActionResult> Edit(UpdatePostCommand command)
//        {
//            if (ModelState.IsValid)
//            {
//                await Mediator.Send(command);
//                return RedirectToAction("Posts", "Post", new { themeId = command.ThemeId });
//            }

//            ModelState.AddModelError("", "The entered data is incorrect");
//            return View(command);
//        }

//        [Authorize]
//        public async Task<IActionResult> Delete(int postId, int themeId)
//        {
//            await Mediator.Send(new DeletePostCommand { PostId = postId });
//            return RedirectToAction("Posts", "Post", new { themeId });
//        }
//    }
//}
