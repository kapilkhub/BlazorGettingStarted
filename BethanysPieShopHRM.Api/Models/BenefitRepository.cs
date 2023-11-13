using BethanysPieShopHRM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Api.Models
{
	public class BenefitRepository : IBenefitRepository
	{
		private readonly IEmployeeRepository _employeeRepository;
		private readonly AppDbContext _appDbContext;

		public BenefitRepository(IEmployeeRepository employeeRepository, AppDbContext appDbContext)
		{
			_employeeRepository = employeeRepository;
			_appDbContext = appDbContext;
		}
		public async Task<List<EmployeeBenefitModel>> GetEmployeeBenefits(int employeeId)
		{
			var employee = _employeeRepository.GetEmployeeById(employeeId);
			var benefits = await _appDbContext.Benefits.ToListAsync();

			var employeeBenefits = await _appDbContext.Entry(employee).Collection(a => a.EmployeeBenefits)
				  .Query().ToListAsync();

			List<EmployeeBenefitModel> employeeBenefitList = (from b in benefits
															  join eb in employeeBenefits on b.Id equals eb.BenefitId into model
															  from m in model.DefaultIfEmpty()
															  select new EmployeeBenefitModel { 
															  BenefitId = b.Id,
															  Description = b.Description,
															  EndDate = m?.EndDate ?? null,
															  Premium = b.Premium,
															  Selected= m == null? false: true,
															  StartDate = m?.StartDate ?? null
															  }).ToList();
			return employeeBenefitList;

		}
	}
}
