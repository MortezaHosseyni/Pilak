using System.ComponentModel.DataAnnotations;

namespace Pilak.Database.Entities
{
    public abstract class BaseEntity
    {
        [Key] public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
