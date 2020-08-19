using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSecondLevelCache.DataLayer.Entities
{
    public class Tag
    {
        public Tag()
        {
            TagProducts = new HashSet<TagProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<TagProduct> TagProducts { get; set; }
    }
}
