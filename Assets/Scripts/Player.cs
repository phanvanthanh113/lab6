using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float noveX = Input.GetAxis("Horizontal");
        float noveY = Input.GetAxis("Vertical");
        Vector3 novement = new Vector3(noveX, noveY, 0f);
        transform.position += novement * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Respawn"))
        {
            Destroy(gameObject);
        }
    }
}
