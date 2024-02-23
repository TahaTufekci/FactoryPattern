using Interfaces;
using Tanks;
using UnityEngine;

namespace Factories
{
    public class TankFactory : MonoBehaviour, IFactory
    {
        [SerializeField] private GameObject tankPrefab;

        public const int TANK_TYPE_1 = 0;

        // Method to create and return a product based on the product type and position
        public IProduct GetProduct(int productType, Vector3 position)
        {
            switch (productType)
            {
                case TANK_TYPE_1:
                    var tank = Instantiate(tankPrefab);
                    tank.transform.position = position;
                    return new Tank();
            }
            return null;
        }
    }
}
