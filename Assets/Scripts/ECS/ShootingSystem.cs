using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;

namespace CompleteProject
{
    public struct BulletSpawner : IComponentData
    {
        public Entity Prefab;
    }
    
    public struct Speed : IComponentData
    {
        public float Value;
    }
    
   
    public partial struct ShootingSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
    }
}