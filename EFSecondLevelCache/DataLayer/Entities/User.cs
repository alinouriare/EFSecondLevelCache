using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSecondLevelCache.DataLayer.Entities
{
    public class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public UserStatus  UserStatus { get; set; }

        public virtual ICollection<Post>  Posts { get; set; }

        public virtual ICollection<Product>  Products { get; set; }
    }

    public enum UserStatus
    {
        Active,
        Disabled
    }
}
