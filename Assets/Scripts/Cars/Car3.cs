using Interfaces;
using UnityEngine;

namespace Cars
{
    public class Car3 : IProduct
    {
        private string _productName;
        public string ProductName => _productName;
        public void Initialize()
        {
            _productName = "Car 3";
        }
    }
}