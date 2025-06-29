using UnityEngine;

public class Play : MonoBehaviour
{
    public float velocidade = 40;
    public float forcaDoPulo = 4;

    private SpriteRenderer sprite;
    private Rigidbody2D rb;


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

    }



    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
            sprite.flipX = false;

        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, forcaDoPulo), ForceMode2D.Impulse);
        }
        
    }
}
