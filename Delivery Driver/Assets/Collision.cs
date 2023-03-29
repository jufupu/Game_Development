using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Oh god Rmac you've crashed again!!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("oh no rmac thats a speed camera!!");
    }
}