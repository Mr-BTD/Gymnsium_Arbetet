using System;
using UnityEngine;

public class PipMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadzone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
