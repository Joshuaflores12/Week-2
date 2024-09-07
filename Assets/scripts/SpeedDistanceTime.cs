using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDistanceTime : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
     [SerializeField] public float distance;
     [SerializeField] public float speed;
     [SerializeField] public float time;

    public void MoveTowardsTarget()
    {
        player.transform.position = Vector2.MoveTowards(player.transform.position,target.transform.position, speed * Time.deltaTime); 
    }

    public void Calculation() 
    {

        distance = Vector2.Distance(player.transform.position, target.transform.position);
        time = distance / speed;
    }

    private void Update()
    {
        Calculation();
        MoveTowardsTarget();
    }
}
