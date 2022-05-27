using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMenuRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public float xAngle;
    public float yAngle;
    public float zAngle;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Rotate obstacles in help menu
        obstacle.transform.Rotate(xAngle,yAngle,zAngle);
    }
}
