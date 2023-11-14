using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHRM.Shared.Model;
using System.Text.Json;

namespace BethanysPieShopHRM.App.Services
{
	public class BenefitDataService : IBenefitDataService
	{
		private readonly HttpClient _httpClient;

		public BenefitDataService(HttpClient httpClient)
        {
			_httpClient = httpClient;
		}
        public async Task<IEnumerable<EmployeeBenefitModel>> GetForEmployee(Employee employee)
		{
			return await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeBenefitModel>>
			   (await _httpClient.GetStreamAsync($"api/benefit/{employee.EmployeeId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
		}
	}
}
