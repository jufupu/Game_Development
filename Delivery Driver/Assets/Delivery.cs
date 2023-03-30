using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Oh god Rmac you've crashed again!!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.tag == "Package")
       {
            Debug.Log("Package picked up!");
            hasPackage = true;
       }
       if (other.tag == "Customer" && hasPackage)
       {
            Debug.Log("Package Delivered to customer!");
       }
    }
}