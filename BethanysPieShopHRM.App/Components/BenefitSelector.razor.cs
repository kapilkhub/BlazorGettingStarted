﻿using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.ComponentsLibrary;
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
	public partial class BenefitSelector
	{
		[Parameter]
		public Employee Employee { get; set; }

		[Inject]
		public IBenefitDataService BenefitDataService { get; set; }

		private IEnumerable<EmployeeBenefitModel> benefits = null;

		[Parameter]
		public EventCallback<bool>  OnPremiumToggle { get; set; }

		[CascadingParameter]
		public Theme Theme { get; set; }

		private List<DateField> dateFields = new List<DateField>();
		private DateField dateFieldRef { set { dateFields.Add(value); } }



		private bool SaveButtonDisabled = true;

		private async Task CheckBoxChanged(ChangeEventArgs e, EmployeeBenefitModel benefit)
		{
			benefit.Selected = Convert.ToBoolean(e.Value);
			if (benefit.Selected)
			{
				benefit.StartDate = DateTime.Now;
				benefit.EndDate = DateTime.Now.AddYears(1);
			}
			SaveButtonDisabled = false;

			await OnPremiumToggle.InvokeAsync(benefit.Selected && benefit.Premium);
		}

		private async Task SaveClick() 
		{
			SaveButtonDisabled = true;
		}

		private void RevertClick()
		{
			dateFields.ForEach(async df => await df.Revert());
		}

		protected override async Task OnInitializedAsync()
		{
			benefits  = await BenefitDataService.GetForEmployee(Employee);
		}
	}
}
