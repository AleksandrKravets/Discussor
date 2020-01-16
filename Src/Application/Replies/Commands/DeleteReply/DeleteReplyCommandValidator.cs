using FluentValidation;

namespace Discussor.Core.Application.Replies.Commands.DeleteReply
{
    public class DeleteReplyCommandValidator : AbstractValidator<DeleteReplyCommand>
    {
        public DeleteReplyCommandValidator()
        {
            RuleFor(x => x.ReplyId).GreaterThan(0);
        }
    }
}
