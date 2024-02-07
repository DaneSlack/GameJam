using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolderMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-5f, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, 1500f));
            Debug.Log("Bounced");
        }
    }
}

