using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.U2D;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    float speedMulti = 1f;

    private Rigidbody2D rb;
    [SerializeField]
    private bool IsJumping;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speedMulti * 4000f * Time.deltaTime, rb.velocity.y);
        }

        if (Input.GetButton("Jump") && IsJumping == false)
        {
            rb.AddForce(new Vector2 (rb.velocity.x, 15f));
            Debug.Log("Jumped");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            IsJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsJumping = true;
        }
    }
}
