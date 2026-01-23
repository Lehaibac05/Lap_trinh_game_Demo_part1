using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;

    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootBullet()
    {
        Instantiate(
            bulletPrefab,
            transform.position,
            transform.rotation
        );
    }
}
