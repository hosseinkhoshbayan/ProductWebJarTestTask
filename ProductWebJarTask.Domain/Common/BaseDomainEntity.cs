using System.ComponentModel.DataAnnotations;

namespace ProductWebJarTask.Domain.Common;

public abstract class BaseDomainEntity
{
    [Key]
    public long Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime LastModifiedDate { get; set; }

}