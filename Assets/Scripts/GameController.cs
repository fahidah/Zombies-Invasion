using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] zombies;


    private void Update()
    {
        Instantiate(zombies[Random.Range(0, zombies.Length)], transform.position, Quaternion.identity);
    }
}
