using FluentValidation;

namespace Discussor.Core.Application.Replies.Queries.GetReply
{
    public class GetReplyQueryValidator : AbstractValidator<GetReplyQuery>
    {
        public GetReplyQueryValidator()
        {
            RuleFor(x => x.ReplyId).GreaterThan(0);
        }
    }
}
