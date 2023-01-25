using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal"); 
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        //Keep Player in Bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //if statement for the Projectile
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a Projectile from the Player
            Instantiate(projectilePrefab, transform.position + new Vector3(0,1,0), projectilePrefab.transform.rotation);
        }

    }
    private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
}
