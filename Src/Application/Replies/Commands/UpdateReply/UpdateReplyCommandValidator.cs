using FluentValidation;

namespace Discussor.Core.Application.Replies.Commands.UpdateReply
{
    public class UpdateReplyCommandValidator : AbstractValidator<UpdateReplyCommand>
    {
        public UpdateReplyCommandValidator()
        {
            RuleFor(x => x.Content).MaximumLength(10000);
            RuleFor(x => x.PostId).GreaterThan(0);
            RuleFor(x => x.ReplyId).GreaterThan(0);
        }
    }
}
