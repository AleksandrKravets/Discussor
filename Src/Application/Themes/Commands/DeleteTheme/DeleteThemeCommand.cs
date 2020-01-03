using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Themes.Commands.DeleteTheme
{
    public class DeleteThemeCommand : IRequest
    {
        public int ThemeId { get; set; }
    }
}
