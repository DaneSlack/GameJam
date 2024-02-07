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
            //rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speedMulti * 2000f * Time.deltaTime, rb.velocity.y));
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speedMulti * 3000f * Time.deltaTime, rb.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && IsJumping == false)
        {
            rb.AddForce(new Vector2 (rb.velocity.x, 1500f));
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
