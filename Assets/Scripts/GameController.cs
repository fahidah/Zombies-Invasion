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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void SpawnZombies()
    {
        Instantiate(zombies[Random.Range(0, zombies.Length)], new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)), Quaternion.identity);

    }

    public void Spawn()
    {
        InvokeRepeating("SpawnZombie", 2.0f, 1.0f);
    }
}
