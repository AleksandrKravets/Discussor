using FluentValidation;

namespace Discussor.Core.Application.Posts.Commands.DeletePost
{
    public class DeletePostCommandValidator : AbstractValidator<DeletePostCommand>
    {
        public DeletePostCommandValidator()
        {
            RuleFor(v => v.PostId).GreaterThan(0);
        }
    }
}
