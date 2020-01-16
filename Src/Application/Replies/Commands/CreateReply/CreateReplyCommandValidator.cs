using FluentValidation;

namespace Discussor.Core.Application.Replies.Commands.CreateReply
{
    public class CreateReplyCommandValidator : AbstractValidator<CreateReplyCommand>
    {
        public CreateReplyCommandValidator()
        {
            RuleFor(x => x.PostId).GreaterThan(0);
            RuleFor(x => x.Content).MaximumLength(10000);
            RuleFor(x => x.CreatorId).NotEmpty();
        }
    }
}
