using Core.DataAccess.Abstract;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? PhotoUrl { get; set; }
        public bool IsDeleted { get; set; }

    }
}