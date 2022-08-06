using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] zombies;

    private void Awake()
    {
        //play zombie 
    }

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }


    private void SpawnZombies()
    {
        Instantiate(zombies[Random.Range(0, zombies.Length)], transform.position, Quaternion.identity);

    }

    public void Spawn()
    {
        InvokeRepeating("SpawnZombie", 2.0f, 1.0f);
    }
}
