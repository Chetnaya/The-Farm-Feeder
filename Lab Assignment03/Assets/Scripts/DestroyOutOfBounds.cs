using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
//    private int topBound = -60;
//    private float lowerBound = 1;

    void Update()
    {
        // if(transform.position.z > topBound)
        // {
        //     Destroy(gameObject);
        // }

        // else if(transform.position.z < lowerBound)
        // {
        //     Destroy(gameObject);
        // }
        

        
    }
    
    //Destroy if they collide 
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
 
    }
   
}
    



