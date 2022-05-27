using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public PlayerBehaviour movement;
    public Rigidbody rb;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Obstacle"){
            //Game Over and Send Player Flying when hitting an Obstacle
            FindObjectOfType<GameManager>().EndGame();
            rb.freezeRotation = false;
            rb.useGravity = false;
            rb.detectCollisions = false;
            rb.mass = 0.5f;
            rb.AddTorque((Random.value-0.5f)*200,(Random.value-0.5f)*200,(Random.value-0.5f)*200);
            rb.AddForce(50,150,-50);
            Debug.Log("Survived for "+Time.time+" seconds!");
        }
        if(collisionInfo.gameObject.tag == "Ground"){
            //Reset ability to Jump
            FindObjectOfType<PlayerBehaviour>().jump = true;
        }
    }
}
