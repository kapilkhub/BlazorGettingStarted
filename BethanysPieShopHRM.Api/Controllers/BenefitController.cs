using BethanysPieShopHRM.Api.Migrations;
using BethanysPieShopHRM.Api.Models;
using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopHRM.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	
	public class BenefitController: Controller
	{
		private readonly IBenefitRepository _benefitRepository;

		public BenefitController(IBenefitRepository benefitRepository)
        {
			_benefitRepository = benefitRepository;
		}
        [HttpGet("{employeeId}")]
		public async Task<ActionResult<EmployeeBenefitModel>> GetEmployeeBenefit(int employeeId)
		{
			return Ok(await _benefitRepository.GetEmployeeBenefits(employeeId));
		}

	}
}
