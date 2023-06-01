using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipe;
    public LogicScript logic;
    public float spawnRate = 2;
    public float heightOffset = 10;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
        if(logic.gameHasStarted)
        {
            SpawnPipe();
        }
 
    }

    // Update is called once per frame
    void Update()
    {

        if (logic.gameHasStarted)
        { 
            if (timer <spawnRate) 
            {
                timer += Time.deltaTime;
            }
            else
            {
                SpawnPipe();
                timer = 0;
            }
        }
    }
    

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
    
}
