using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
   public int topBound = -70;
//    public float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        // if(transform.position.z == topBound)
        // {
        //     Destroy(gameObject);
        // }

        // else if(transform.position.z < lowerBound)
        // {
        //     Destroy(gameObject);
        // }
        

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        // if(collision.gameObject.tag == "Finish")
        // {
        //     Destroy(gameObject);
        // }
 
    }
   
}
    



