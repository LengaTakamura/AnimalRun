using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] public float playerSpeed = 1.0f;

    [SerializeField] public float playerHp = 5;

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
            rb.AddForce(Vector2.up * playerSpeed);
        }

        // S�L�[�i����ړ��j
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * playerSpeed);
        }

        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * playerSpeed);
        }

        // A�L�[�i���ړ��j
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * playerSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Horse"))
        {
        }
    }


}