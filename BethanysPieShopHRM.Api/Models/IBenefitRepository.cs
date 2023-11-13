


using BethanysPieShopHRM.Shared.Model;

namespace BethanysPieShopHRM.Api.Models
{
	public interface IBenefitRepository
	{
		Task<List<EmployeeBenefitModel>> GetEmployeeBenefits(int employeeId);
	}
}
