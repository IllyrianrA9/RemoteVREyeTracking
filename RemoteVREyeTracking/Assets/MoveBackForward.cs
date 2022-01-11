using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveBackForward : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    float rotspeed;
    public float speed;
    float WPradius = 1;
    int counter = 0;
    public GameObject ball;
    private bool isMoving = true;

    void Start()
    {

    }




    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current++;
                //current = Random.Range(0, waypoints.Length);
                if (current >= waypoints.Length)
                {
                    isMoving = false;

                }

            }
            if(current < waypoints.Length)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
            }
            
        }
        else{
            if (current >= waypoints.Length)
            {
                current = waypoints.Length - 1;
            }
            if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current--;
                //current = Random.Range(0, waypoints.Length);
                if(current == 0)
                {
                    isMoving = true;
                }

            }
            if (counter == 30)
            {
                speed = 0;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
            }
        }
    }
}
