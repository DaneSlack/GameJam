using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownDestroyer : MonoBehaviour
{
    //[SerializeField]
    //GameObject clown;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Destroyed");
            Destroy(gameObject);
        }
    }
}
