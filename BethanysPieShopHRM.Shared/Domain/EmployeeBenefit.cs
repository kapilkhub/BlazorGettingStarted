using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopHRM.Shared.Domain
{
	public class EmployeeBenefit
	{
		[Key]
		public int Id { get; set; }
		public int EmployeeId { get; set; }		
		public int BenefitId { get; set; }
		public DateTimeOffset? StartDate { get; set; }
		public DateTimeOffset? EndDate { get; set; }
		public Employee Employee { get; set; } = null!;
		public Benefit Benefit { get; set; } = null!;
    }
}
