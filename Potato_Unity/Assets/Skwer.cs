using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skwer : MonoBehaviour {

    public float speed = 100;
    public float jump = 550.3f;
    private Rigidbody2D rb;
    private bool isGrounded;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown("space") && (isGrounded == true))
        {
            rb.AddForce(new Vector2(0, jump));
            isGrounded = false;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }
}
