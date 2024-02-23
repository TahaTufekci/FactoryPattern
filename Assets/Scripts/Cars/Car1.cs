using Interfaces;

namespace Cars
{
    public class Car1 : IProduct
    {
        private string _productName;
        public string ProductName => _productName;
        public void Initialize()
        {
            _productName = "Car 1";
        }
    }
}
