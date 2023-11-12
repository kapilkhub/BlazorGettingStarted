using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopHRM.Shared.Domain
{
	public class Benefit
	{
		[Key]
		public int Id { get; set; }
		public string Description { get; set; } = string.Empty;
		public bool Premium { get; set; }

	
		public ICollection<EmployeeBenefit> EmployeeBenefits { get; set; } = new List<EmployeeBenefit>();
	}
}
