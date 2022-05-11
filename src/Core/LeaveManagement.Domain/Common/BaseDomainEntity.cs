namespace src.Core.LeaveManagement.Domain.Common;

public abstract class BaseDomainEntity<T>
{
  public T PKId { get; set; } = default!;
  public DateTime CreatedDate { get; set; }
  public string? CreatedBy { get; set; }
  public DateTime LastModifiedDate { get; set; }
  public string? LastModifiedBy { get; set; }
}
