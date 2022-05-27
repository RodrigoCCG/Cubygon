using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 cameraOffset;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make camera follow player on a specific offset
        transform.position = player.position + cameraOffset;
        //Close game when hitting Escape
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
