using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 1;
    public EnemyHealth myHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);

            if (myHealth != null)
                myHealth.TakeDamage(1000);
            else
                Destroy(gameObject);
        }
    }
}