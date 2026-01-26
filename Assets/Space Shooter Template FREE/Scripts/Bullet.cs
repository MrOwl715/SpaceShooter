using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Tốc độ bay của đạn (trong PDF là flySpeed [cite: 51])
    public float speed = 10f;

    void Update()
    {
        // Di chuyển đạn lên trên theo trục Y (Vector3.up tương đương với new Vector3(0, 1, 0))
        // Time.deltaTime giúp game mượt trên mọi FPS
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // [PRO TIP] Tự hủy đạn nếu bay quá xa để đỡ tốn ram (Giáo trình chưa dạy nhưng nên làm)
        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
}