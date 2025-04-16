using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0; // Điểm số hiện tại
    public TMP_Text scoreText; // Tham chiếu đến TextMeshPro trên UI

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Điểm hiện tại: " + score);
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score; // Cập nhật UI
        }
    }
}