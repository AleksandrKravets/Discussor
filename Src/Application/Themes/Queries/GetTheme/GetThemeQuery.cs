using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Themes.Queries.GetTheme
{
    public class GetThemeQuery : IRequest<ThemeViewModel>
    {
        public int Id { get; set; }
    }
}
