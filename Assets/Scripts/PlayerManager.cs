using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]float speed = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Moving();
    }

    void Moving()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector2.up * speed;
        }

        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector2.down * speed;
        }

        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * speed;
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * speed;
        }

    }
}