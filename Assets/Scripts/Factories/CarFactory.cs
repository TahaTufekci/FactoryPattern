using Cars;
using Interfaces;
using UnityEngine;

namespace Factories
{
    public class CarFactory : MonoBehaviour, IFactory
    {
        [SerializeField] private GameObject carPrefab1;
        [SerializeField] private GameObject carPrefab2;
        [SerializeField] private GameObject carPrefab3;

        public const int CAR_TYPE_1 = 0;
        public const int CAR_TYPE_2 = 1;
        public const int CAR_TYPE_3 = 2;

        // Method to create and return a product based on the product type and position
        public IProduct GetProduct(int productType, Vector3 position)
        {
            switch(productType)
            {
                case CAR_TYPE_1:
                    var car1 = Instantiate(carPrefab1);
                    car1.transform.position = position;
                    return new Car1();
                case CAR_TYPE_2:
                    var car2 = Instantiate(carPrefab2);
                    car2.transform.position = position;
                    return new Car2();
                case CAR_TYPE_3:
                    var car3 = Instantiate(carPrefab3);
                    car3.transform.position = position;
                    return new Car3();
            }
            return null;
        }
   
    }
}
