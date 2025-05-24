using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public int packageCount = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Move,bitch!");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if the this we trigger then print package picked up.
        if (other.tag == "Package")
        {
            Debug.Log("Order picked up!");
            packageCount++;
        }
        if (other.tag == "Customer" && packageCount > 0)
        {
            Debug.Log("Package delivered!");
            packageCount--;
        }
        else if (other.tag == "Customer" && packageCount <= 0)
        {
            Debug.Log("No packages to deliver!");
        }

    }
}
