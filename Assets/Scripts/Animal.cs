using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update

    protected float health;
    protected string name;
    protected Rigidbody animalRb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    public virtual void Jump()
    {

    }
}
