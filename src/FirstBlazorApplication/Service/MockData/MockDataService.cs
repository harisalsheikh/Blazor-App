using FirstBlazorApplication.Models;

namespace FirstBlazorApplication.Service.MockData
{
    public class MockDataService
    {
        private static List<HyperCars> _hyperCars = default!;

        public static List<HyperCars>? HyperCars
        {
            get
            {
                _hyperCars ??= InitializeMockHyperCars();

                return _hyperCars;
            }
        }
        
        private static List<HyperCars> InitializeMockHyperCars()
        {
            var c1 = new HyperCars
            {
                Id = 1,
                CarName = "Mclaren F1", 
                Engine = "V12", 
                HorsePower =  618, 
                TopSpeed = 243,
                Cost = "$ 25,000,000"
            };
            var c2 = new HyperCars
            {
                Id = 2,
                CarName = "Buggat Chiron",
                Engine = "W16",
                HorsePower = 1500,
                TopSpeed = 250,
                Cost = "$ 3,000,000"
            };
            var c3 = new HyperCars
            {
                Id = 3,
                CarName = "Mercedes AMG One",
                Engine = "V6",
                HorsePower = 748,
                TopSpeed = 217,
                Cost = "$ 2,653,000"
            };
            var c4 = new HyperCars
            {
                Id = 4,
                CarName = "Ferrari LaFerrar",
                Engine = "V8",
                HorsePower = 900,
                TopSpeed = 211,
                Cost = "$ 900,000"
            };
            var c5 = new HyperCars
            {
                Id = 5,
                CarName = "Porsche 918 Spyder",
                Engine = "V8",
                HorsePower = 918,
                TopSpeed = 211,
                Cost = "$ 900,000"
            };
            var c6 = new HyperCars
            {
                Id = 6,
                CarName = "Pagaaani Huayra BC",
                Engine = "V8",
                HorsePower = 745,
                TopSpeed = 230,
                Cost = "$ 2,550,000"
            };

            return new List<HyperCars>() { c1, c2, c3, c4, c5, c6 };
        }

    }
}
