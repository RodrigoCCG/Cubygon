using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0,0,speed);
    }

    // Update is called once per frame
    void Update()
    {
        //Move Obstacles towards player and destroy them when they leave view.
        rb.AddForce(0, 0, speed * Time.deltaTime);
        if(transform.position.z < -70){
            Destroy(gameObject);
        }
    }

}
