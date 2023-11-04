using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    private float jumpForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        name = "Pastor Aleman";
        health = 100f;
        animalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();       
        }
    }

    public override void Jump()
    {
        animalRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
