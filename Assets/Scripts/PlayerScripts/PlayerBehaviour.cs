using UnityEngine;
public class PlayerBehaviour : MonoBehaviour
{

    public Rigidbody rb;
    public float horizontalForce = 30.0f;
    public bool jump = true;
    // Start is called before the first frame update
    void Start()
    {
        this.jump = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
        //Game over the player if they fall off the platform
        if(rb.position.y < 0){
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void PlayerMovement(){
        //Move player left and right 
        rb.AddForce(this.horizontalForce * Time.deltaTime * Input.GetAxis("Horizontal") , 0, 0, ForceMode.VelocityChange);
        //Allow Player to jump and float when holding down the Space Bar
        if(Input.GetKey("space")){
            if(jump){
                this.jump = false;
                rb.AddForce(0, 1000 * Time.deltaTime, 0, ForceMode.Impulse);
            }else{
                rb.AddForce(0, 1000 * Time.deltaTime, 0,ForceMode.Force);
            }
        }
    }
}
