using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    float speedMulti = 1f;

    private Rigidbody2D rb;

    private float t = 0.0f;
    private bool moving = false;



    /*float acceleration = 0.6f;
    float maxSpeed = 30f;
    float speed = 0f;
    private object Movement;*/

    // Start is called before the first frame update
    void Start()
    {


        /*var playerMovement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * Time.deltaTime * moveSpeed;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("MoveRight"))
        {
            transform.Translate(Input.GetAxis("MoveRight") * speedMulti * 20f * Time.deltaTime, 0, 0);
        }

        /*float ySpeed = Rigidbody2D.

        if (
        {

        }*/

        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2 (0, 50f);
        }



        /*   if (speed < maxSpeed)
           {
               speed += acceleration * Time.deltaTime;
           }

           transform.position.x = transform.position.x + speed * Time.deltaTime;

           transform.position = new Vector3(
               transform.position.x + Movement.x,
               transform.position.y + Movement.y,
               transform.position.z);*/
    }
}
