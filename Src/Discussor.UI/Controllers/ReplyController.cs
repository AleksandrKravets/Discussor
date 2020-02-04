using Discussor.Core.Application.Replies.Commands.CreateReply;
using Discussor.Core.Application.Replies.Commands.DeleteReply;
using Discussor.Core.Application.Replies.Commands.UpdateReply;
using Discussor.Core.Application.Replies.Queries.GetReply;
using Discussor.Core.Domain.Entities;
using Discussor.WebUI.Infrastructure.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Discussor.WebUI.Controllers
{
    [Authorize]
    [EmailConfirmation]
    public class ReplyController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ReplyController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // получать запросы по postId

        [HttpPost]
        public async Task<IActionResult> Reply(CreateReplyCommand command)
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
        public async Task<IActionResult> Edit(UpdateReplyCommand command)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(command);
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteReplyCommand { ReplyId = id });
            return NoContent();
        }
    }
}
