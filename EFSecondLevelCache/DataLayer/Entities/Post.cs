using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSecondLevelCache.DataLayer.Entities
{
    public class Post
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public virtual User  User { get; set; }
        public int UserId { get; set; }

    }

    public class Page : Post
    {

    }
}
