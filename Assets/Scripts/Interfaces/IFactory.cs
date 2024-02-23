using UnityEngine;

namespace Interfaces
{
   public interface IFactory
   {
      public IProduct GetProduct(int productType, Vector3 position);
   }
}
