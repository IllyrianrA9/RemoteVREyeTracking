using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveBall : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    float rotspeed;
    public float speed;
    float WPradius = 0.5f;
    int counter = 0;
    public GameObject ball;

    void Start(){
        
   }
  



    // Update is called once per frame
    void Update()
    {
         if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;
            //current = Random.Range(0, waypoints.Length);
            if (current >= waypoints.Length)
            {
                current = 0;

            }
            
        }
        if(counter == 30)
        {
            speed = 0;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        }
    }
}
