using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    public Slider healthSlider; // Gắn Slider ở Inspector
    public int maxHealth = 10;  // Số lần cần nhặt để thắng
    private int currentHealth = 0;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move * speed * Time.deltaTime, 0, 0);
        if (move > 0)
            transform.localScale = new Vector3(1, 1, 1); // Quay mặt phải
        else if (move < 0)
            transform.localScale = new Vector3(-1, 1, 1); // Quay mặt trái
    }

    // Gọi hàm này khi nhặt trứng
    public void IncreaseHealth()
    {
        currentHealth++;
        healthSlider.value = (float)currentHealth / maxHealth;

        Debug.Log("Máu hiện tại: " + currentHealth + "/" + maxHealth);

        if (currentHealth >= maxHealth)
        {
            Debug.Log("Bạn đã thắng!");
            SceneManager.LoadScene("SceneWin");
        }
    }

}
