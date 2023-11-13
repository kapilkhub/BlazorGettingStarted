using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHRM.Shared.Model;

namespace BethanysPieShopHRM.App.Services
{
	public interface IBenefitDataService
	{
		Task<IEnumerable<EmployeeBenefitModel>> GetForEmployee(Employee employee);
	}
}
