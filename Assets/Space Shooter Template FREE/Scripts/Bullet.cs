using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public float speed = 10f;

    void Update()
    {


        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}