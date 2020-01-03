using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Themes.Commands.CreateTheme
{
    public class CreateThemeCommand : IRequest<int>
    {
        public string Title { get; set; }
        public byte[] Image { get; set; }
    }
}
