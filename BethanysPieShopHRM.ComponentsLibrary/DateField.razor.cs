using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.ComponentsLibrary
{
	public partial class DateField
	{
		private DateTimeOffset? origDate;

		[Parameter]
		public DateTimeOffset? Date { get; set; }

		[Parameter]
		public EventCallback<DateTimeOffset?> DateChanged { get; set; }

		[Parameter(CaptureUnmatchedValues = true)]
		public Dictionary<string, object> InputAttributes { get; set; }

		public async Task Revert()
		{
			if (Date != origDate)
			{
				Date = origDate;
				await DateChanged.InvokeAsync(Date);
			}
		}

		private async Task OnDateChanged(ChangeEventArgs e)
		{
			var date = Convert.ToString(e?.Value);
			if (DateTime.TryParse(date, out DateTime newDate))
			{
				Date = newDate;
				await DateChanged.InvokeAsync(Date);
			}

		}

		protected override void OnInitialized()
		{
			origDate = Date;
		}
	}
}
