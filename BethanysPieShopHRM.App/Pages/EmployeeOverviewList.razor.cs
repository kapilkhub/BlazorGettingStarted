using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverviewList
    {
        public List<Employee> Employees { get; set; } = default!;

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

    }
}
