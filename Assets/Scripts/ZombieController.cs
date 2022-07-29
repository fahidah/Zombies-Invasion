using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{

    //variable declarations
    public float moveSpeed;

    static Animator animator;


    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveZombie();
    }

    private void MoveZombie()
    {
        if (animator.name == "Walking")
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World); //Move zombie forward after idle is complete 
        }
    }
}