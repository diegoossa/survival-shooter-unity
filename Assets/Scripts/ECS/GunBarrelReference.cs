using UnityEngine;

public class GunBarrelReference : MonoBehaviour
{
    public static Vector3 GunBarrelPosition;

    private void Update()
    {
        GunBarrelPosition = transform.position;
    }
}
