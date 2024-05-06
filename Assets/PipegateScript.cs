using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipegateScript : MonoBehaviour
{
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void OnTriggerEnter2D(Collider2D other) {
        logic.addScore();
    }
}
