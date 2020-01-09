using System.Collections.Generic;

namespace Discussor.Core.Domain.Entities
{
    // Это будет таблица юзеров  для связи с остальными сущностями
    // а потом свяжем ее 1 к 1 с identityUser
    //[ComplexType]
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<Theme> Themes { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }

        public ApplicationUser()
        {
            Themes = new HashSet<Theme>();
            Posts = new HashSet<Post>();
            Replies = new HashSet<Reply>();
        }
    }
}
