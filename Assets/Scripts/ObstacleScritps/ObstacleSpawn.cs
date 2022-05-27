using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public Transform[] obstacles;

    public float spawnDelay;
    public float minDelay;
    public float spawnSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = Random.Range(1.0f, 5.0f);
        Invoke("SpawnObstacle", spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Time.time > timeStart +timeEnd){
            obstChoice = (int)(Random.value*4);
            int offset = ((int)(Random.value*3))-1;
            switch(obstChoice)
            {
                case 0:
                offsets = new Vector3(0,1,0);
                Instantiate(obstacle, transform.position + offsets, Quaternion.identity);
                break;
                case 1:
                offsets = new Vector3(offset,1,0);
                Instantiate(longObstacle, transform.position + offsets, Quaternion.identity);
                break;
                case 2:
                offsets = new Vector3(offset,1,0);
                Instantiate(tallObstacle, transform.position + offsets, Quaternion.identity);
                break;
                case 3:
                offsets = new Vector3(offset,2.5f,0);
                Instantiate(Floatobstacle, transform.position + offsets, Quaternion.identity);
                break;
                default:
                break;
            }
            if (spawnSpeed > minDelay){
                spawnSpeed -= 0.05f;
                spawnSpeed = (float)System.Math.Round(spawnSpeed,2);
            }
            timeStart = (Time.time);
            timeEnd = (Random.value+spawnSpeed);
        }
        */
    }

    void SpawnObstacle(){
        //Select a Random Obstacle
        int obstChoice = Random.Range(0, obstacles.Length);

        //Create the correct offset for the type of obstacle
        int offsetX;
        if(obstChoice == 0){
            offsetX = 0;
        }else{
            offsetX = Random.Range(-1, 2);
        }

        Vector3 offsets = new Vector3(offsetX, 0, 0);

        //Spawn Obstacle from list
        Transform obst = obstacles[obstChoice];
        Instantiate(obst, transform.position + obst.position +  offsets, obst.rotation);

        //Reduce the delay between Spawns
        if (spawnSpeed > minDelay){
            spawnSpeed -= 0.1f;
        }

        spawnDelay = (Random.Range(0.5f, 1.5f) + spawnSpeed);
        
        //Queue next Obstacle
        Invoke("SpawnObstacle", spawnDelay);
    }
}
