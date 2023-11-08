using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BethanysPieShopHRM.ComponentsLibrary
{
	public partial class Map
	{
		string elementId = $"map-{Guid.NewGuid():D}";
		[Parameter]
		public double Zoom { get; set; }

		[Parameter]
		public List<Marker> Markers { get; set; }

		[Inject]
		public IJSRuntime JSRuntime { get; set; }

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (Markers is not null && Markers.Count >= 1)
			{
				await JSRuntime.InvokeVoidAsync("deliveryMap.showOrUpdate", elementId, Markers);
			}

		}
	}
}
