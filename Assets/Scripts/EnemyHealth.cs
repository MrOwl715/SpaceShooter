using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Kéo Prefab vụ nổ vào đây")]
    public GameObject explosionPrefab;

    // Hàm này chạy khi có vật thể (có Is Trigger) bay xuyên qua
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // [PRO TIP] Kiểm tra xem cái chạm vào có phải là Đạn hay không?
        // Nếu muốn kỹ tính hơn thì dùng: if(collision.CompareTag("Bullet"))
        Debug.Log("Đã chạm vào: " + collision.name);
        // 1. Xóa viên đạn vừa chạm vào mình (để nó không bay xuyên qua)
        Destroy(collision.gameObject);

        // 2. Kích hoạt cái chết
        Die();
    }

    private void Die()
    {
        // Tạo vụ nổ tại chỗ chết
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }

        // Xóa phi thuyền địch
        Destroy(gameObject);
    }
}