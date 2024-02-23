using Interfaces;

namespace Tanks
{
    public class Tank : IProduct
    {
        private string _productName;
        public string ProductName => _productName;
        public void Initialize()
        {
            _productName = "Tank";
        }
    }
}
