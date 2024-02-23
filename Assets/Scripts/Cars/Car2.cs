using Interfaces;
using UnityEngine;

namespace Cars
{
    public class Car2 : IProduct
    {
        private string _productName;
        public string ProductName => _productName;
        public void Initialize()
        {
            _productName = "Car 2";
        }
    }
}