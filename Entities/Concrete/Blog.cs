using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Category? Category { get; set; }
    }
}
