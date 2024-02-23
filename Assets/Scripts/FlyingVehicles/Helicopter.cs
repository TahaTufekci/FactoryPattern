using Interfaces;

namespace FlyingVehicles
{
    public class Helicopter : IProduct
    {
        private string _productName;
        public string ProductName => _productName;
        public void Initialize()
        {
            _productName = "Helicopter";
        }
    }
}
