using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject TopDownViewCamera;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Switch1"))
        {
            MainCamera.SetActive(true);
            TopDownViewCamera.SetActive(false);
        }

        if(Input.GetButtonDown("Switch2"))
        {
            MainCamera.SetActive(false);
            TopDownViewCamera.SetActive(true);
            
        }
        
    }
}
