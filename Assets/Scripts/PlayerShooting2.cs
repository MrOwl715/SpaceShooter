using UnityEngine;

public class PlayerShooting2 : MonoBehaviour
{
    [Header("Cài đặt")]
    public GameObject bulletPrefab; // Kéo Prefab Bullet vào đây
    public float shootingInterval = 0.2f; // Thời gian giãn cách giữa 2 viên đạn [cite: 267]

    private float lastBulletTime; // Lưu thời điểm bắn viên đạn trước đó [cite: 268]

    void Update()
    {
        // Cách 1: Bắn khi click chuột (Theo trang 6 PDF [cite: 177])
        // Lưu ý: Input.GetMouseButton(0) là giữ chuột, GetMouseButtonDown(0) là click 1 lần
        if (Input.GetMouseButton(0))
        {
            ShootControl();
        }
    }

    void ShootControl()
    {
        // Logic bắn tự động (Theo trang 8 PDF [cite: 280])
        // Nếu thời gian hiện tại > thời gian lần bắn cuối + khoảng nghỉ
        if (Time.time > lastBulletTime + shootingInterval)
        {
            SpawnBullet();
            lastBulletTime = Time.time; // Cập nhật lại thời gian vừa bắn [cite: 287]
        }
    }

    void SpawnBullet()
    {
        // Tạo viên đạn tại vị trí của máy bay (transform.position)
        // Quaternion.identity nghĩa là không xoay
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}