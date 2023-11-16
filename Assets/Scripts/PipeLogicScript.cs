using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLogicScript : MonoBehaviour
{
    public LogicScript logic;
    public birdScript bird;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<birdScript>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        bird.birdIsAlive = false;
    }
}
