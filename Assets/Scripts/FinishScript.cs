using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public TransitionScript transition;

    private void Start()
    {
        transition = GameObject.FindGameObjectWithTag("Transition").GetComponent<TransitionScript>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        transition.endScreen(2);
    }

}
