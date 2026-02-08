using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;
    public Vector3 bulletOffset;
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        var bullet = Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }
}
