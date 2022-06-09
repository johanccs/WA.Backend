using System.ComponentModel.DataAnnotations;

namespace WA.Data.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
