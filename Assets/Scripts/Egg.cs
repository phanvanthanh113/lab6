using UnityEngine;

public class Egg : MonoBehaviour
{
    public int scoreValue = 10; // Giá trị điểm khi nhặt trứng

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Farmer"))
        {
            // Cộng điểm
            GameManager gameManager = FindFirstObjectByType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddScore(scoreValue);
                Debug.Log("Farmer nhặt trứng! +10 điểm");
            }

            // Gọi tăng máu
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            Debug.Log("Đã tìm thấy Player: " + player);

            if (player != null)
            {
                player.IncreaseHealth();
            }

            Destroy(gameObject); // Hủy trứng sau khi nhặt
        }
        else
        {
            // Tự hủy sau 3 giây nếu rơi không nhặt
            Destroy(gameObject, 3f);
        }
    }
}
