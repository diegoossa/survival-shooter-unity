using Unity.Entities;
using Unity.Transforms;

namespace CompleteProject
{
    public struct GunBarrel : IComponentData { }

    [UpdateAfter(typeof(TransformSystemGroup))]
    public partial struct UpdateGunBarrelPositionSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            foreach (var transform in SystemAPI.Query<RefRW<LocalTransform>>().WithAll<GunBarrel>())
            {
                transform.ValueRW.Position = GunBarrelReference.GunBarrelPosition;
            }
        }
    }
}