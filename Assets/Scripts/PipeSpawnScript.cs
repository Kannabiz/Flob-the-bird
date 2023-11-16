using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public GameObject home;
    public LogicScript logic;
    public string gameMode;
    private bool end = false;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 3;
    public int distanceStoryMode;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        spawnPipe();

        gameMode = PlayerPrefs.GetString("gameMode");
    }

    void Update()
    {
        if(end == false && logic.distance > distanceStoryMode && gameMode == "StoryMode")
        {
            StartCoroutine(spawnHouse());
            end = true;
        }
        else if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else if (end == false && timer > spawnRate)
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    public IEnumerator spawnHouse()
    {
        yield return new WaitForSeconds(2);
        Instantiate(home, new Vector3(transform.position.x, 0, 0), transform.rotation);
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;


        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
