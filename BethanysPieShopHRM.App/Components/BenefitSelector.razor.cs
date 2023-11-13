using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
	public partial class BenefitSelector
	{
		[Parameter]
		public Employee Employee { get; set; }

		[Inject]
		public IBenefitDataService BenefitApiService { get; set; }

		protected override async Task OnInitializedAsync()
		{
			
		}
	}
}
