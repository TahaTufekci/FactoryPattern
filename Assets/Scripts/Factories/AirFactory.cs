using FlyingVehicles;
using Interfaces;
using UnityEngine;

namespace Factories
{
    public class AirFactory : MonoBehaviour, IFactory
    {
        [SerializeField] private GameObject helicopterPrefab;
        [SerializeField] private GameObject planePrefab;

        public const int HELICOPTER = 0;
        public const int AEROPLANE = 1;

        // Method to create and return a product based on the product type and position
        public IProduct GetProduct(int productType, Vector3 position)
        {
            switch(productType)
            {
                case HELICOPTER:
                    var aeroplane = Instantiate(helicopterPrefab);
                    aeroplane.transform.position = position;
                    return new Helicopter();
                case AEROPLANE:
                    var plane = Instantiate(planePrefab);
                    plane.transform.position = position;
                    return new Aeroplane();
            }
            return null;
        }
    }
}
