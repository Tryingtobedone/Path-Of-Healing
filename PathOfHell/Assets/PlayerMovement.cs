using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(rb.velocity.x) < speed)
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector2.right * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector2.left * speed);
            }
        }
    }
}
