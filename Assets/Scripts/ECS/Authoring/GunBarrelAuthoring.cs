using Unity.Entities;
using UnityEngine;

namespace CompleteProject
{
    public class GunBarrelAuthoring : MonoBehaviour
    {
        public class GunBarrelBaker : Baker<GunBarrelAuthoring>
        {
            public override void Bake(GunBarrelAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent<GunBarrel>(entity);
            }
        }
    }
}