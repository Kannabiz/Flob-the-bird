using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public birdScript bird;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<birdScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && bird.birdIsAlive == true)
        {
            logic.increaseDistance(1);
        }
    }
}
