using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
       HorizontalInput = Input.GetAxis("Horizontal"); 
       transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
    }
}
