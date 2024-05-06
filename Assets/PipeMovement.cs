using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float pipeMovespeed = 5;
    public float deadzone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadzone) {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
        transform.position += Vector3.left * pipeMovespeed * Time.deltaTime;
    }
    
}
