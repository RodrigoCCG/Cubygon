using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        //Position Camera
        mainCam.transform.position = new Vector3(0,15,-25);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Rotate the camera around the platform
        mainCam.transform.RotateAround(new Vector3(0,0,0),new Vector3(0,15,0), 20 * Time.deltaTime);

        //Close Game when hitting Escape
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
