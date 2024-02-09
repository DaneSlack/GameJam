using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallOver : MonoBehaviour
{
    [SerializeField]
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
    }
        // Update is called once per frame
        void Update()
    {
            if (target.rotation.y <= -80)
        {
            Debug.Log("YouFellOver");
        }
        if (target.rotation.y >= 80)
        {
            Debug.Log("YouFellOver");
        }
    }
}
