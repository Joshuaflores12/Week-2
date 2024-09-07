using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public float acceleration;
    public float initial_V;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTowardsTarget() 
    {
    
    }

    public void CalculateAcceleration()
    {
         Rigidbody rb = GetComponent<Rigidbody>();
    }

}
