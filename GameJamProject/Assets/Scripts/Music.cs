using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField]
    public AudioSource audioSource;
    void Start()
    {
        audioSource.Play();
    }
}
