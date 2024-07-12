using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] public float playerSpeed = 1.0f;

    [SerializeField] public float playerHp = 5;

    [SerializeField] List<Sprite> animals = new List<Sprite>();

    SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        animal = Animal.normal;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Moving();
    }
    void Moving()
    {
        if (Input.GetKey(KeyCode.W) && animal != Animal.crab && animal != Animal.owl && animal != Animal.frog)
        {
            rb.AddForce(Vector2.up * playerSpeed);
        }

        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S) && animal != Animal.crab && animal != Animal.owl && animal != Animal.frog)
        {
            rb.AddForce(Vector2.down * playerSpeed);
        }

        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D) && animal != Animal.owl && animal != Animal.frog)
        {
            rb.AddForce(Vector2.right * playerSpeed);
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A) && animal != Animal.owl && animal != Animal.frog)
        {
            rb.AddForce(Vector2.left * playerSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && animal == Animal.horse && animal != Animal.frog || Input.GetKeyDown(KeyCode.Space)&& animal == Animal.owl)
        {
            rb.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Horse"))
        {
            animal = Animal.horse;
            spriteRenderer.sprite = animals[0];

        }
        else if (collision.gameObject.tag == ("Crab"))
        {
            animal = Animal.crab;
            spriteRenderer.sprite = animals[1];
        }
        else if (collision.gameObject.tag == ("Frog"))
        {
            animal = Animal.frog;
            spriteRenderer.sprite = animals[2];
        }
        else if (collision.gameObject.tag == ("Owl"))
        {
            animal = Animal.owl;
            spriteRenderer.sprite = animals[3];
        }

    }





    enum Animal { horse, crab, normal, owl, frog }

    Animal animal;
}