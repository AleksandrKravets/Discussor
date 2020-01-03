using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Themes.Queries.GetThemesList
{
    public class GetThemesListQuery : IRequest<ThemesListViewModel>
    {
    }
}
