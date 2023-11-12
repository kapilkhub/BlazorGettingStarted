using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
    public partial class EmployeeRow
    {
        [Parameter]
        public Employee Employee { get; set; }

        private bool showBenefits { get; set; }

	}
}
