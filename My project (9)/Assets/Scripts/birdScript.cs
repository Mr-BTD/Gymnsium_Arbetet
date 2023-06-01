using System;
using Unity.VisualScripting;
using UnityEngine;

public class birdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public float UpwordsSpeed;
    public bool birdIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.gameHasStarted)
        {
            myRigidbody.simulated = true;
            if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
            {
                myRigidbody.velocity = Vector2.up * UpwordsSpeed;
            }
        }
        else if (!logic.gameHasStarted) 
        {
            myRigidbody.simulated = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        trunToGameOver();
    }

    void trunToGameOver()
    {
        birdIsAlive = false;
        logic.gameOver();
    }
   
}
