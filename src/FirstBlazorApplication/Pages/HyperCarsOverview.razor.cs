using FirstBlazorApplication.Models;
using FirstBlazorApplication.Service.MockData;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace FirstBlazorApplication.Pages
{
    public partial class HyperCarsOverview
    {
        public List<HyperCars> hyperCars { get; set; } = default!;

        protected override void OnInitialized()
        {
            hyperCars = MockDataService.HyperCars;
        }
    }
}
