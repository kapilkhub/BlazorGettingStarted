using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHRM.Shared.Model;

namespace BethanysPieShopHRM.App.Services
{
	public class BenefitDataService : IBenefitDataService
	{
		private readonly HttpClient _httpClient;

		public BenefitDataService(HttpClient httpClient)
        {
			_httpClient = httpClient;
		}
        public Task<IEnumerable<EmployeeBenefitModel>> GetForEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}
	}
}
