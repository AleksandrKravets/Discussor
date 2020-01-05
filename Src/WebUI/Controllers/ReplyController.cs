using Application.Replies.Commands.CreateReply;
using Application.Replies.Commands.DeleteReply;
using Application.Replies.Commands.UpdateReply;
using Application.Replies.Queries.GetReply;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ReplyController : BaseController
    {
        [HttpGet]
        public IActionResult Reply(int postId)
        {
            return View(new CreateReplyCommand { PostId = postId });
        }

        [HttpPost]
        public async Task<IActionResult> Reply(CreateReplyCommand command)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(command);
                return RedirectToAction("Post", "Post", new { postId = command.PostId });
            }

            ModelState.AddModelError("", "The entered data is incorrect");
            return View(command);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int replyId)
        {
            var reply = await Mediator.Send(new GetReplyQuery { ReplyId = replyId });

            return View(new UpdateReplyCommand
            {
                Content = reply.Content,
                ReplyId = reply.Id,
                PostId = reply.PostId
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateReplyCommand command)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(command);
                return RedirectToAction("Post", "Post", new { postId = command.PostId });
            }

            ModelState.AddModelError("", "The entered data is incorrect");
            return View(command);
        }

        public async Task<IActionResult> Delete(int replyId, int postId)
        {
            await Mediator.Send(new DeleteReplyCommand { ReplyId = replyId });
            return RedirectToAction("Post", "Post", new { postId });
        }
    }
}
