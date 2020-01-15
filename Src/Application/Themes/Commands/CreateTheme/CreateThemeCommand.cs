using MediatR;

namespace Discussor.Core.Application.Themes.Commands.CreateTheme
{
    public class CreateThemeCommand : IRequest<int>
    {
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string CreatorId { get; set; }
    }
}
