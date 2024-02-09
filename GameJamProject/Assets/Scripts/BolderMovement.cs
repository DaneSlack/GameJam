using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BolderMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    int bounceCounter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        int directionOfTravel;
        rb = GetComponent<Rigidbody2D>();
        directionOfTravel = Random.Range(1, 2);
        if (directionOfTravel == 2)
        {
            directionOfTravel = -1;

        }
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
            rb.AddForce(new Vector2(rb.velocity.x, Random.Range(2000f,500f)));
            Debug.Log("Bounced");
            bounceCounter ++;
        }
    }
}

